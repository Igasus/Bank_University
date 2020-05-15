using Bank_Logic;
using System.Text.Json;



namespace Bank_Serialization
{
    public class SerializationTransferAction
    {
        public double AmountOfMoney { get; set; }
        public string TransferType { get; set; }
        public string Date { get; set; }



        public SerializationTransferAction() { }



        public SerializationTransferAction(TransferAction transferAction)
        {
            AmountOfMoney = transferAction.AmountOfMoney;
            TransferType = transferAction.GetStringType();

            Date = transferAction.Date.Json();
        }



        static public SerializationTransferAction Deserialize(string json)
        {
            SerializationTransferAction result = JsonSerializer.Deserialize<SerializationTransferAction>(json);

            return result;
        }
    }
}
