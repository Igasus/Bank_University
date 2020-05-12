using System;



namespace Bank_Logic
{
    public class Deposit
    {
        private string _title = "";


        public Bank Bank { get; private set; }
        public double AnnualRate { get; private set; }
        public int Duration { get; set; }
        public double TotalAccount { get; private set; }
        public LocalDeposit[] LocalDeposits { get; private set; }

        // Title must be unique
        public string Title
        {
            get => _title;
            private set
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

            LocalDeposits = new LocalDeposit[0];
        }



        // Adding new LocalDeposit to array of child-deposits
        public void AddLocalDeposit(LocalDeposit deposit)
        {
            LocalDeposit[] temporary = new LocalDeposit[LocalDeposits.Length + 1];

            for (int i = 0; i < LocalDeposits.Length; i++)
                temporary[i] = LocalDeposits[i];
            temporary[temporary.Length - 1] = deposit;

            LocalDeposits = temporary;
        }



        // Finding index of child-deposit array. If array doesn't have needed item returns -1
        public int GetLocalDepositIndex(LocalDeposit deposit)
        {
            for (int i = 0; i < LocalDeposits.Length; i++)
                if (deposit.Equals(LocalDeposits[i]))
                    return i;
            return -1;
        }



        // Removes certain LocalDeposit in array
        public void RemoveLocalDeposit(LocalDeposit deposit)
        {
            int index = GetLocalDepositIndex(deposit);
            if (index == -1)
                throw new Exception("Local deposit doesn't exist");

            LocalDeposit[] temporary = new LocalDeposit[LocalDeposits.Length - 1];

            for (int i = 0; i < index; i++)
                temporary[i] = LocalDeposits[i];
            for (int i = index + 1; i < LocalDeposits.Length; i++)
                temporary[i - 1] = LocalDeposits[i];

            LocalDeposits = temporary;
        }



        // Updates all child-deposits
        public void UpdateLocalDeposits()
        {
            foreach (LocalDeposit deposit in LocalDeposits)
            {
                deposit.Update();
            }
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
            result += $"|- LocalDeposits.Length: {LocalDeposits.Length} \n";

            return result;
        }
    }
}