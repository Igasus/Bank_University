namespace Bank_Logic
{
    // Enum for TransferActionClass
    public enum TransferType
    {
        REPLENISH,
        WITHDRAW
    }





    // Stores Transfer info. Is used in Deposits histories
    public struct TransferAction
    {
        public Date Date { get; private set; }
        public TransferType Type { get; private set; }
        public double AmountOfMoney { get; private set; }



        public TransferAction(Date date, TransferType type, double amountOfMoney)
        {
            Date = new Date(date);
            Type = type;
            AmountOfMoney = amountOfMoney;
        }



        // GetStringType() returns string value of TransferType enum
        public string GetStringType()
        {
            string result = "UNKNOWN";

            switch (Type)
            {
                case TransferType.WITHDRAW:
                    result = "WITHDRAW";
                    break;
                case TransferType.REPLENISH:
                    result = "REPLENISH";
                    break;
            }

            return result;
        }



        // Overriding ToString() method
        public override string ToString()
        {
            string result = "TransferAction: \n";
            result += $"|- Date: {Date} \n";
            result += $"|- Type: {GetStringType()} \n";
            result += $"|- AmountOfMoney: {AmountOfMoney} \n";

            return result;
        }
    }
}