using System;



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
        public LocalDeposit[] Deposits { get; private set; }

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

            Deposits = new LocalDeposit[0];
        }



        // Creates new LocalDeposit
        public void OpenDeposit(Deposit parentDeposit, double seedCapital)
        {
            LocalDeposit deposit = new LocalDeposit(parentDeposit, seedCapital, this);
            parentDeposit.AddLocalDeposit(deposit);

            LocalDeposit[] temporary = new LocalDeposit[Deposits.Length + 1];
            for (int i = 0; i < Deposits.Length; i++)
                temporary[i] = Deposits[i];
            temporary[temporary.Length - 1] = deposit;

            Deposits = temporary;
        }



        // Deletes LocalDeposit with certain index in parent-array
        public void CloseDeposit(int index)
        {
            Deposits[index].ParentDeposit.RemoveLocalDeposit(Deposits[index]);
            Deposits[index].Withdraw(Deposits[index].Account);
            LocalDeposit[] temporary = new LocalDeposit[Deposits.Length - 1];

            for (int i = 0; i < index; i++)
                temporary[i] = Deposits[i];
            for (int i = index + 1; i < Deposits.Length; i++)
                temporary[i - 1] = Deposits[i];

            Deposits = temporary;
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