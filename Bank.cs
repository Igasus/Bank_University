using System;
using System.Collections.Generic;
using Bank_University;
using Bank_Serialization;



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
        public User Login(string username, string password)
        {
            foreach (User user in Users)
                if (user.Username == username)
                    return user.Password == password ? user : null;
            return null;
        }



        // Returns index of User in Users list
        public int GetUserIndex(User user)
        {
            for (int i = 0; i < Users.Count; i++)
                if (user.Equals(Users[i]))
                    return i;
            return -1;
        }



        // Deletes User from Bank
        public void DeleteUser(int index)
        {
            if (index < 0 || index >= Users.Count)
                throw new Exception($"Users list length is {Users.Count}, doesn't exit user with index {index}");

            Deposits.ForEach(deposit => deposit.CloseLocalDeposits(Users[index]));
            Users.RemoveAt(index);
        }

        public void DeleteUser(User user)
        {
            int userIndex = GetUserIndex(user);

            if (userIndex == -1)
                throw new Exception($"User '{user.Username}' doesn't exist in Bank '{Title}'");

            DeleteUser(userIndex);
        }



        // Returns index of certain deposit in Deposits list
        public int GetDepositIndex(Deposit deposit)
        {
            for (int i = 0; i < Deposits.Count; i++)
                if (deposit.Equals(Deposits[i]))
                    return i;
            return -1;
        }



        // Creates new bank Deposit
        public void CreateDeposit(Bank bank, string title, double annualRate, int duration)
        {
            Deposit deposit = new Deposit(bank, title, annualRate, duration);
            Deposits.Add(deposit);
        }



        // Deletes certain Deposit
        public void DeleteDeposit(int index)
        {
            Deposits[index].DeleleAllLocalDeposits();
            Deposits.RemoveAt(index);
        }

        public void DeleteDeposit(Deposit deposit)
        {
            int index = GetDepositIndex(deposit);

            if (index == -1)
                throw new Exception($"Bank '{Title}' doesn't have Deposit '{deposit.Title}'");

            DeleteDeposit(index);
        }



        // Transfers money between two accounts
        public void TransferMoney(User sender, User receiver, double amountOfMoney)
        {
            if (amountOfMoney <= 0)
                throw new Exception("Transferring amount must be more than zero(0)");

            try
            {
                sender.Account -= amountOfMoney;
            }
            catch (Exception)
            {
                throw new Exception($"User '{sender.Username}' doesn't have enough money for transfer.");
            }
            
            receiver.Account += amountOfMoney;
        }



        // Searching User by: Username, Name, Surname
        public List<User> SearchUsers(string toFind)
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



        // Searching Deposit by: Title, AnnualRate, Duration, TotalAccount
        public List<Deposit> SearchDeposits(string toFind)
        {
            List<Deposit> resultsByTitle = new List<Deposit>();
            List<Deposit> resultsByAnnualRate = new List<Deposit>();
            List<Deposit> resultsByDuration = new List<Deposit>();
            List<Deposit> resultsByTotalAccount = new List<Deposit>();

            Deposits.ForEach(deposit => {
                if (deposit.Title.ToLower().Contains(toFind.ToLower()))
                    resultsByTitle.Add(deposit);
                else if (String.Format("{0:0.00}", deposit.AnnualRate * 100).Contains(toFind))
                    resultsByAnnualRate.Add(deposit);
                else if (deposit.Duration.ToString().Contains(toFind))
                    resultsByDuration.Add(deposit);
                else if (String.Format("{0:0.00}", deposit.TotalAccount).Contains(toFind))
                    resultsByTotalAccount.Add(deposit);
            });

            List<Deposit> result = new List<Deposit>(resultsByTitle.Count +
                                               resultsByAnnualRate.Count +
                                               resultsByDuration.Count + 
                                               resultsByTotalAccount.Count);
            result.AddRange(resultsByTitle);
            result.AddRange(resultsByAnnualRate);
            result.AddRange(resultsByDuration);
            result.AddRange(resultsByTotalAccount);

            return result;
        }



        // Finds User by User.Username
        public User FindUser(string username)
        {
            foreach (User user in Users)
                if (username == user.Username)
                    return user;
            throw new Exception($"User with username '{username}' doesn't exist");
        }



        // Finds Deposit by Deposit.Title
        public Deposit FindDeposit(string title)
        {
            foreach (Deposit deposit in Deposits)
                if (title == deposit.Title)
                    return deposit;
            throw new Exception($"Deposit with title '{title}' doesn't exist");
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



        // Converts json data and fills current Bank object
        static public Bank GetObject(string bankTitle,
            List<SerializationUser> serializationUsers,
            List<SerializationDeposit> serializationDeposits,
            List<SerializationLocalDeposit> serializationLocalDeposits)
        {
            List<User> users = new List<User>();
            List<Deposit> deposits = new List<Deposit>();
            Bank bank = new Bank(bankTitle);

            foreach (SerializationUser serializationUser in serializationUsers)
            {
                User user = User.GetObject(bank, serializationUser);
                users.Add(user);
            }

            foreach (SerializationDeposit serializationDeposit in serializationDeposits)
            {
                Deposit deposit = Deposit.GetObject(bank, serializationDeposit);
                deposits.Add(deposit);
            }

            bank.Users = users;
            bank.Deposits = deposits;

            foreach (SerializationLocalDeposit serializationLocalDeposit in serializationLocalDeposits)
                LocalDeposit.LinkObject(bank, serializationLocalDeposit);

            return bank;
        }
    }
}