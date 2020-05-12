using System;
using System.Collections.Generic;
using Bank_University;



namespace Bank_Logic
{
    public class Bank
    {
        string _title = "";

        public List<User> Users { get; private set; }
        public List<Deposit> Deposits { get; private set; }

        // Bank title must ne unique
        public string Title {
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
                Banks.ForEach(bank => {
                    if (bank.Title.ToLower() == value.ToLower())
                        if (value != _title)
                            throw new Exception("Bank already exist.");
                        else
                            return;
                });

                _title = value;
            }
        }



        public Bank(string title)
        {
            Title = title;
            Users = new List<User>();
            Deposits = new List<Deposit>();
        }



        // Updates all deposits in bank
        public void UpdateDeposits()
        {
            Deposits.ForEach(deposit => deposit.UpdateLocalDeposits());
        }



        // Creates new User
        public void Register(string login, string password)
        {
            User user = new User(login, password, this);
            Users.Add(user);
        }



        // Simple auth.
        public bool Login(string username, string password)
        {
            foreach (User user in Users)
                if (user.Username == username)
                    return user.Password == password;
            return false;
        }



        // Creates new bank Deposit
        public void CreateDeposit(Bank bank, string title, double annualRate, int duration)
        {
            Deposit deposit = new Deposit(bank, title, annualRate, duration);
            Deposits.Add(deposit);
        }



        // Transfers money between two accounts
        public void TransferMoney(User sender, User receiver, double amountOfMoney)
        {
            if (amountOfMoney <= 0)
                throw new Exception("Transferring amount must be more than zero(0)");

            sender.Account -= amountOfMoney;
            receiver.Account += amountOfMoney;
        }



        // Searching User by: Username, Name, Surname
        public List<User> Search(string toFind)
        {
            List<User> resultsByUsername = new List<User>();
            List<User> resultsByName = new List<User>();
            List<User> resultsBySurname = new List<User>();

            Users.ForEach(user => {
                if (user.Username.ToLower().Contains(toFind.ToLower()))
                    resultsByUsername.Add(user);
                else if (user.Name.ToLower().Contains(toFind.ToLower()))
                    resultsByName.Add(user);
                else if (user.Surname.ToLower().Contains(toFind.ToLower()))
                    resultsBySurname.Add(user);
            });

            List<User> result = new List<User>(resultsByUsername.Count +
                                               resultsByName.Count +
                                               resultsBySurname.Count);
            result.AddRange(resultsByUsername);
            result.AddRange(resultsByName);
            result.AddRange(resultsBySurname);

            return result;
        }



        // Overriding Equals() method
        public override bool Equals(object obj)
        {
            try
            {
                Bank bank = (Bank)obj;
                return Title == bank.Title;
            }
            catch (Exception)
            {
                return false;
            }
        }



        // Overriding ToString() method
        public override string ToString()
        {
            string result = "Bank: \n";
            result += $"|- Title: {Title} \n";
            result += "|- Users: \n";
            foreach (User user in Users)
                result += $"|  |- {user.Username} \n";

            result += "|- Deposits: \n";
            foreach (Deposit deposit in Deposits)
                result += $"   |- {deposit.Title}: {deposit.AnnualRate * 100}% {deposit.Duration} months \n";

            return result;
        }



        //-----Static--class--members---------------------------------



        // Stores all program banks
        public static List<Bank> Banks = new List<Bank>();
        public static char[] BannedSymbols = new char[]
            { ' ', '{', '}', '|', '/', '\\', '[', ']', '(', ')', '\'', '\"', '.', ',', '!', '?' };



        // Updates deposits of all banks
        public static void UpdateAllDeposits()
        {
            Banks.ForEach(bank => bank.UpdateDeposits());
        }



        // Creates new program bank
        public static void CreateBank(string title)
        {
            Bank bank = new Bank(title);
            Banks.Add(bank);

            Program.StartForm.UpdateBankList();
        }
    }
}