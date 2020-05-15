using System.Collections.Generic;
using Bank_Logic;
using System.Text.Json;



namespace Bank_Serialization
{
    public class SerializationLocalDeposit
    {
        public double Account { get; set; }
        public string OpenDate { get; set; }
        public string User { get; set; }
        public string ParentDeposit { get; set; }
        public string[] History { get; set; }



        public SerializationLocalDeposit() { }



        public SerializationLocalDeposit(LocalDeposit localDeposit)
        {
            Account = localDeposit.Account;
            OpenDate = localDeposit.OpenDate.Json();
            User = localDeposit.User.Username;
            ParentDeposit = localDeposit.ParentDeposit.Title;

            List<string> history = new List<string>();
            foreach (TransferAction transferAction in localDeposit.History)
                history.Add(transferAction.Json());
            History = history.ToArray();
        }



        static public SerializationLocalDeposit Deserialize(string json)
        {
            SerializationLocalDeposit result = JsonSerializer.Deserialize<SerializationLocalDeposit>(json);
            
            return result;
        }
    }
}
