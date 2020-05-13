using System;
using System.Collections.Generic;



namespace Bank_Logic
{
    public class User
    {
        private string _username = "";
        private string _password;
        private double _account;

        public string Name { get; set; }
        public string Surname { get; set; }
        public Date BirthDate { get; set; }
        public Bank Bank { get; private set; }
        public List<LocalDeposit> Deposits { get; private set; }

        // Username must bew Unique in every bank
        public string Username
        {
            get => _username;
            set
            {
                // Checking if new username is valid
                if (value == "" || value != value.Split(Bank.BannedSymbols)[0])
                {
                    string exceptionMessage = "Username can't be empty or contain such symbols: ";
                    foreach (char symbol in Bank.BannedSymbols)
                        exceptionMessage += $"'{symbol}', ";
                    exceptionMessage = exceptionMessage.TrimEnd(',', ' ');
                    throw new Exception(exceptionMessage);
                }

                // Checking on username existing. If exist -> Error
                Bank.Users.ForEach(user => {
                    if (user.Username.ToLower() == value.ToLower())
                        if (value != _username)
                            throw new Exception("Username already exists.");
                        else
                            return;
                });

                _username = value;
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                // Checking if new password is valid
                if (value == "" || value != value.Split(Bank.BannedSymbols)[0])
                {
                    string exceptionMessage = "Password can't be empty or contain such symbols: ";
                    foreach (char symbol in Bank.BannedSymbols)
                        exceptionMessage += $"'{symbol}', ";
                    exceptionMessage = exceptionMessage.TrimEnd(',', ' ');
                    throw new Exception(exceptionMessage);
                }

                _password = value;
            }
        }

        public double Account
        {
            get => _account;
            set
            {
                if (value < 0)
                    throw new Exception("User's account can't be less than zero(0)");

                _account = value;
            }
        }



        public User(string username, string password, Bank bank)
        {
            Bank = bank;
            Username = username;
            Password = password;

            Name = "";
            Surname = "";
            BirthDate = new Date(1, 1, 1);

            Deposits = new List<LocalDeposit>();
        }



        // Creates new LocalDeposit
        public void OpenDeposit(Deposit parentDeposit, double seedCapital)
        {
            LocalDeposit deposit = new LocalDeposit(parentDeposit, seedCapital, this);
            parentDeposit.AddLocalDeposit(deposit);

            Deposits.Add(deposit);
        }



        // Returns index of certain LocalDeposit in User.Deposits list
        public int GetLocalDepositIndex(LocalDeposit deposit)
        {
            for (int i = 0; i < Deposits.Count; i++)
                if (deposit.Equals(Deposits[i]))
                    return i;
            return -1;
        }



        // Removes LocalDepoit from User.Deposits list
        public void RemoveDeposit(int index)
        {
            if (index < 0 || index >= Deposits.Count)
                throw new Exception($"LocalDeposit with index {index} doesn't exist int list User.Deposits.");

            Deposits.RemoveAt(index);
        }

        public void RemoveDeposit(LocalDeposit deposit)
        {
            int index = GetLocalDepositIndex(deposit);

            if (index == -1)
                throw new Exception($"User {Username} doesn't have deposit {deposit.Title}");

            RemoveDeposit(index);
        }



        // Deletes LocalDeposit from User.Deposits list
        public void CloseDeposit(int index)
        {
            if (index < 0 || index >= Deposits.Count)
                throw new Exception($"LocalDeposit with index {index} doesn't exist int list User.Deposits.");

            LocalDeposit deposit = Deposits[index];

            deposit.Withdraw(deposit.Account);
            deposit.Remove();
        }

        public void CloseDeposit(LocalDeposit deposit)
        {
            int index = GetLocalDepositIndex(deposit);

            if (index == -1)
                throw new Exception($"User {Username} doesn't have deposit {deposit.Title}");

            CloseDeposit(index);
        }



        public void WithdrawDeposit(int index, double amountOfMoney)
        {
            Deposits[index].Withdraw(amountOfMoney);
        }



        public void ReplenishDeposit(int index, double amountOfMoney)
        {
            Deposits[index].Replenish(amountOfMoney);
        }



        public void TransferMoney(User user, double amountOfMoney)
        {
            Bank.TransferMoney(this, user, amountOfMoney);
        }



        // Searching LocalDeposit by: Username, Account, OpenDate, CloseDate
        public List<LocalDeposit> SearchLocalDeposits(string toFind)
        {
            List<LocalDeposit> resultsByUsername = new List<LocalDeposit>();
            List<LocalDeposit> resultsByAccount = new List<LocalDeposit>();
            List<LocalDeposit> resultsByOpenDate = new List<LocalDeposit>();
            List<LocalDeposit> resultsByCloseDate = new List<LocalDeposit>();

            Deposits.ForEach(deposit => {
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
                User user = (User)obj;
                return Bank.Equals(user.Bank)
                       && Username == user.Username;
            }
            catch (Exception)
            {
                return false;
            }
        }



        // Overriding ToString() method
        public override string ToString()
        {
            string result = "User: \n";
            result += $"|- Username: {Username} \n";
            result += $"|- Password: {Password} \n";
            result += $"|- Bank: {Bank.Title} \n";
            result += $"|- Name: {Name} \n";
            result += $"|- Surname: {Surname} \n";
            result += $"|- BirthDate: {BirthDate} \n";
            result += "|- Deposits: \n";
            foreach (LocalDeposit deposit in Deposits)
                result += $"   |- {deposit.Title}: {deposit.Account} \n";

            return result;
        }
    }
}