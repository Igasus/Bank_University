using System;
using System.Collections.Generic;



namespace Bank_Logic
{
    public class Deposit
    {
        private string _title = "";
        private double _annualRate;
        private int _duration;


        public Bank Bank { get; private set; }
        public List<LocalDeposit> LocalDeposits { get; private set; }

        // Duration as amount of months of Deposit
        public int Duration
        {
            get => _duration;
            set
            {
                if (value <= 0)
                    throw new Exception("Duration must be longer than zero months (duration > 0)");

                _duration = value;
            }
        }

        // Money multiplier on deposit close 
        public double AnnualRate
        {
            get => _annualRate;
            set
            {
                if (value <= 0)
                    throw new Exception("Annual rate must be higher than zero (annualRate > 0)");

                _annualRate = value;
            }
        }

        // Total amount of money of LocalDeposits
        public double TotalAccount
        {
            get
            {
                double result = 0;
                LocalDeposits.ForEach(deposit => result += deposit.Account );

                return result;
            }
        }

        // Title must be unique
        public string Title
        {
            get => _title;
            set
            {
                // Checking if new title is valid
                if (value == "" || value != value.Split(Bank.BannedSymbols)[0])
                {
                    string exceptionMessage = "Username can't be empty or contain such symbols: ";
                    foreach (char symbol in Bank.BannedSymbols)
                        exceptionMessage += $"'{symbol}', ";
                    exceptionMessage = exceptionMessage.TrimEnd(',', ' ');
                    throw new Exception(exceptionMessage);
                }

                // Checking on title existing. If exist -> Error
                foreach (Deposit deposit in Bank.Deposits)
                    if (deposit._title.ToLower() == value.ToLower())
                        if (value != _title)
                            throw new Exception("Deposit already exist.");
                        else
                            break;

                _title = value;
            }
        }



        public Deposit(Bank bank, string title, double annualRate, int duration)
        {
            Bank = bank;
            Title = title;
            AnnualRate = annualRate;
            Duration = duration;

            LocalDeposits = new List<LocalDeposit>();
        }



        // Adding new LocalDeposit to array of child-deposits
        public void AddLocalDeposit(LocalDeposit deposit)
        {
            LocalDeposits.Add(deposit);
        }



        // Finding index of child-deposit array. If array doesn't have needed item returns -1
        public int GetLocalDepositIndex(LocalDeposit deposit)
        {
            for (int i = 0; i < LocalDeposits.Count; i++)
                if (deposit.Equals(LocalDeposits[i]))
                    return i;
            return -1;
        }



        // Removes certain LocalDeposit in LocalDeposits list
        public void RemoveLocalDeposit(int index)
        {
            LocalDeposits.RemoveAt(index);
        }

        public void RemoveLocalDeposit(LocalDeposit deposit)
        {
            int index = GetLocalDepositIndex(deposit);
            if (index == -1)
                throw new Exception("Local deposit doesn't exist");

            RemoveLocalDeposit(index);
        }



        // Removes certain user LocalDeposits from current list
        public void CloseLocalDeposits(User user)
        {
            while (true)
            {
                LocalDeposit toCloseDeposit = null;
                foreach (LocalDeposit deposit in LocalDeposits)
                    if (deposit.User.Equals(user))
                    {
                        toCloseDeposit = deposit;
                        break;
                    }

                if (toCloseDeposit == null)
                    break;

                user.CloseDeposit(toCloseDeposit);
            }
        }



        // Deletes all LocalDeposits
        public void DeleleAllLocalDeposits()
        {
            while (LocalDeposits.Count != 0)
                LocalDeposits[0].Close();
        }



        // Updates all child-deposits
        public void UpdateLocalDeposits()
        {
            foreach (LocalDeposit deposit in LocalDeposits)
            {
                deposit.Update();
            }
        }



        // Searching LocalDeposit by: Username, Account, OpenDate, CloseDate
        public List<LocalDeposit> SearchLocalDeposits(string toFind)
        {
            List<LocalDeposit> resultsByUsername = new List<LocalDeposit>();
            List<LocalDeposit> resultsByAccount = new List<LocalDeposit>();
            List<LocalDeposit> resultsByOpenDate = new List<LocalDeposit>();
            List<LocalDeposit> resultsByCloseDate = new List<LocalDeposit>();

            LocalDeposits.ForEach(deposit => {
                if (deposit.User.Username.ToLower().Contains(toFind.ToLower()))
                    resultsByUsername.Add(deposit);
                else if (String.Format("{0:0.00}", deposit.Account).Contains(toFind))
                    resultsByAccount.Add(deposit);
                else if (deposit.OpenDate.ToString().Contains(toFind))
                    resultsByOpenDate.Add(deposit);
                else if (deposit.CloseDate.ToString().Contains(toFind))
                    resultsByCloseDate.Add(deposit);
            });

            List<LocalDeposit> result = new List<LocalDeposit>(resultsByUsername.Count +
                                               resultsByAccount.Count +
                                               resultsByOpenDate.Count +
                                               resultsByCloseDate.Count);
            result.AddRange(resultsByUsername);
            result.AddRange(resultsByAccount);
            result.AddRange(resultsByOpenDate);
            result.AddRange(resultsByCloseDate);

            return result;
        }



        // Overriding Equals() method
        public override bool Equals(object obj)
        {
            try
            {
                Deposit deposit = (Deposit)obj;
                return Bank.Equals(deposit.Bank)
                       && Title == deposit.Title;
            }
            catch (Exception)
            {
                return false;
            }
        }



        // Overriding ToString() method
        public override string ToString()
        {
            string result = "Deposit: \n";
            result += $"|- Title: {Title} \n";
            result += $"|- Bank: {Bank.Title} \n";
            result += $"|- AnnualRate: {AnnualRate} \n";
            result += $"|- Duration: {Duration} \n";
            result += $"|- LocalDeposits.Length: {LocalDeposits.Count} \n";

            return result;
        }
    }
}