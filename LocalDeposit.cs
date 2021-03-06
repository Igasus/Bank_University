﻿using System;
using System.Collections.Generic;
using Bank_Serialization;
using System.Text.Json;



namespace Bank_Logic
{
    public class LocalDeposit
    {
        public User User { get; private set; }
        public double Account { get; private set; }
        public Date OpenDate { get; private set; }
        public List<TransferAction> History { get; private set; }
        public Deposit ParentDeposit { get; private set; }

        // Get-only properties for easier getting Deposit info
        public string Title { get => ParentDeposit.Title; }
        public double AnnualRate { get => ParentDeposit.AnnualRate; }
        public int Duration { get => ParentDeposit.Duration; }
        public Bank Bank { get => ParentDeposit.Bank; }
        public Date CloseDate
        {
            get
            {
                Date closeDate = new Date(OpenDate);
                closeDate.Month += Duration;

                return closeDate;
            }
        }



        // Private "empty" constructor for deserialization
        private LocalDeposit() { }



        // Setting LocalDeposit info, replenish SeedCapital
        public LocalDeposit(Deposit parentDeposit, double seedCapital, User user)
        {
            ParentDeposit = parentDeposit;
            OpenDate = new Date(Date.CurrentDate);
            CloseDate.Month += ParentDeposit.Duration;
            User = user;

            History = new List<TransferAction>();
            Replenish(seedCapital);
        }



        // Withdraw method
        public void Withdraw(double amountOfMoney)
        {
            if (Account < amountOfMoney)
                throw new Exception("Not enough money on Deposit account.");

            if (amountOfMoney <= 0)
                throw new Exception("Amount of money must be more than zero (> 0).");

            Account -= amountOfMoney;
            User.Account += amountOfMoney;

            TransferAction action = new TransferAction(Date.CurrentDate, TransferType.WITHDRAW, amountOfMoney);
            History.Add(action);
        }



        // Replenish method
        public void Replenish(double amountOfMoney)
        {
            if (User.Account < amountOfMoney)
                throw new Exception("Not enough money on User account.");

            if (amountOfMoney <= 0)
                throw new Exception("Amount of money must be more than zero (> 0).");

            User.Account -= amountOfMoney;
            Account += amountOfMoney;

            TransferType transferType = History.Count == 0 ? TransferType.DEPOSIT : TransferType.REPLENISH;
            TransferAction action = new TransferAction(Date.CurrentDate, transferType, amountOfMoney);
            History.Add(action);
        }



        // Method that checks Deposit on finish
        public void Update()
        {
            while (Date.CurrentDate >= CloseDate)
            {
                double withdrawTotalMoneyAmount = 0;
                List<TransferAction> replenishActions = new List<TransferAction>();
                foreach (TransferAction action in History)
                    if (action.Type == TransferType.WITHDRAW)
                        withdrawTotalMoneyAmount += action.AmountOfMoney;
                    else
                        replenishActions.Add(action);

                int extraDay = Date.RangeContainsExtraDay(OpenDate, CloseDate) ? 1 : 0;
                double finalAmountOfMoney = 0;
                Date lastActionDate = new Date(OpenDate);
                foreach (TransferAction action in replenishActions)
                {
                    finalAmountOfMoney *= Math.Pow(1 + ParentDeposit.AnnualRate, (double)(action.Date - lastActionDate) / (365 + extraDay));
                    lastActionDate.SetDate(action.Date);
                    double delta = Math.Min(action.AmountOfMoney, withdrawTotalMoneyAmount);
                    finalAmountOfMoney += action.AmountOfMoney - delta;
                    withdrawTotalMoneyAmount -= delta;
                }
                finalAmountOfMoney *= Math.Pow(1 + ParentDeposit.AnnualRate, (double)(CloseDate - lastActionDate) / (365 + extraDay));

                Account = finalAmountOfMoney;
                OpenDate.SetDate(CloseDate);

                History.Clear();
                TransferAction depositUpdateAction = new TransferAction(OpenDate, TransferType.DEPOSIT, finalAmountOfMoney);
                History.Add(depositUpdateAction);
            }
        }



        // Closing current LocalDeposit
        public void Close()
        {
            User.CloseDeposit(this);
        }



        // Removing current LocalDeposit from Deposit and User lists
        public void Remove()
        {
            User.RemoveDeposit(this);
            ParentDeposit.RemoveLocalDeposit(this);
        }



        // Converts current object to json for serialization
        public string Json()
        {
            SerializationLocalDeposit serializationLocalDeposit = new SerializationLocalDeposit(this);
            string result = JsonSerializer.Serialize<SerializationLocalDeposit>(serializationLocalDeposit);

            return result;
        }



        // Overriding Equals() method
        public override bool Equals(object obj)
        {
            try
            {
                LocalDeposit deposit = (LocalDeposit)obj;
                return ParentDeposit.Equals(deposit.ParentDeposit)
                       && User.Equals(deposit.User)
                       && OpenDate.Equals(deposit.OpenDate)
                       && Account == deposit.Account;
            }
            catch (Exception)
            {
                return false;
            }
        }



        // Overriding ToString() method
        public override string ToString()
        {
            string result = "LocalDeposit: \n";
            result += $"|- ParentDeposit: {Title} \n";
            result += $"|- AnnualRate: {AnnualRate} \n";
            result += $"|- Account: {Account} \n";
            result += $"|- OpenDate: {OpenDate} \n";
            result += $"|- CloseDate: {CloseDate} \n";
            result += "|- History: \n";
            foreach (TransferAction action in History)
                result += $"   |- {action.Date}: {action.GetStringType()}. AmountOfMoney: {action.AmountOfMoney} \n";

            return result;
        }



        //-----Static--class--members---------------------------------



        // Converts SerializationUser object to User object
        static public void LinkObject(Bank bank, SerializationLocalDeposit serializationLocalDeposit)
        {
            string toFindUsername = serializationLocalDeposit.User;
            string toFindTitle = serializationLocalDeposit.ParentDeposit;

            User user = bank.FindUser(toFindUsername);
            Deposit deposit = bank.FindDeposit(toFindTitle);

            LocalDeposit localDeposit = new LocalDeposit();
            localDeposit.User = user;
            localDeposit.ParentDeposit = deposit;
            localDeposit.Account = serializationLocalDeposit.Account;
            localDeposit.OpenDate = Date.Deserialize(serializationLocalDeposit.OpenDate);

            localDeposit.History = new List<TransferAction>();
            foreach (string transferActionJson in serializationLocalDeposit.History)
            {
                SerializationTransferAction serializationTransferAction =
                    SerializationTransferAction.Deserialize(transferActionJson);

                TransferAction transferAction = TransferAction.GetObject(serializationTransferAction);

                localDeposit.History.Add(transferAction);
            }

            user.LinkLocalDeposit(localDeposit);
            deposit.LinkLocalDeposit(localDeposit);
        }
    }
}