﻿using System;
using System.Collections.Generic;



namespace Bank_Logic
{
    public class LocalDeposit
    {
        public User User { get; private set; }
        public double Account { get; private set; }
        public Date OpenDate { get; private set; }
        public Date CloseDate { get; private set; }
        public List<TransferAction> History { get; private set; }
        public Deposit ParentDeposit { get; private set; }

        // Get-only properties for easier getting Deposit info
        public string Title { get => ParentDeposit.Title; }
        public double AnnualRate { get => ParentDeposit.AnnualRate; }



        // Setting LocalDeposit info, replenish SeedCapital
        public LocalDeposit(Deposit parentDeposit, double seedCapital, User user)
        {
            ParentDeposit = parentDeposit;
            OpenDate = new Date(Date.CurrentDate);
            CloseDate = new Date(OpenDate);
            CloseDate.Month += ParentDeposit.Duration;
            User = user;

            History = new List<TransferAction>();
            Replenish(seedCapital);
        }



        // Withdraw method
        public void Withdraw(double amountOfMoney)
        {
            if (Account < amountOfMoney)
                throw new Exception("LocalDeposit->Withdraw. Not enough money on Deposit account.");

            Account -= amountOfMoney;
            User.Account += amountOfMoney;

            TransferAction action = new TransferAction(Date.CurrentDate, TransferType.WITHDRAW, amountOfMoney);
            History.Add(action);
        }



        // Replenish method
        public void Replenish(double amountOfMoney)
        {
            if (User.Account < amountOfMoney)
                throw new Exception("LocalDeposit->Withdraw. Not enough money on User account.");

            User.Account -= amountOfMoney;
            Account += amountOfMoney;

            TransferAction action = new TransferAction(Date.CurrentDate, TransferType.REPLENISH, amountOfMoney);
            History.Add(action);
        }



        // Method that checks Deposit on finish
        public void Update()
        {
            // Console.WriteLine("\nCurrent: " + Date.CurrentDate + "\nOpen: " + OpenDate + "\nClose: " + CloseDate);
            if (Date.CurrentDate < CloseDate)
                return;

            double withdrawTotalMoneyAmount = 0;
            List<TransferAction> replenishActions = new List<TransferAction>();
            foreach (TransferAction action in History)
                switch (action.Type)
                {
                    case TransferType.WITHDRAW:
                        withdrawTotalMoneyAmount += action.AmountOfMoney;
                        break;
                    case TransferType.REPLENISH:
                        replenishActions.Add(action);
                        break;
                }

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
            CloseDate.Month += ParentDeposit.Duration;
            // Console.WriteLine("New account: " + Account);
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
    }
}