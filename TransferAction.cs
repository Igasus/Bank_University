using Bank_Serialization;
using System.Text.Json;



namespace Bank_Logic
{
    // Enum for TransferActionClass
    public enum TransferType
    {
        REPLENISH,
        WITHDRAW,
        DEPOSIT
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
                case TransferType.DEPOSIT:
                    result = "DEPOSIT";
                    break;
            }

            return result;
        }



        // Converts current object to json for serialization
        public string Json()
        {
            SerializationTransferAction serializationTransferAction = new SerializationTransferAction(this);
            string result = JsonSerializer.Serialize<SerializationTransferAction>(serializationTransferAction);

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



        //-----Static--class--members---------------------------------



        // Converts SerializationTransferAction object to TransferAction object
        static public TransferAction GetObject(SerializationTransferAction serializationTransferAction)
        {
            string transferTypeString = serializationTransferAction.TransferType;
            string dateJson = serializationTransferAction.Date;

            TransferType transferType = TransferType.DEPOSIT;
            if (transferTypeString == "REPLENISH")
                transferType = TransferType.REPLENISH;
            else if (transferTypeString == "WITHDRAW")
                transferType = TransferType.WITHDRAW;

            Date date = Date.Deserialize(dateJson);
            double amountOfMoney = serializationTransferAction.AmountOfMoney;

            TransferAction transferAction = new TransferAction(date, transferType, amountOfMoney);

            return transferAction;
        }
    }
}