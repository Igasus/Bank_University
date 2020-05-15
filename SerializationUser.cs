using System.Collections.Generic;
using Bank_Logic;
using System.Text.Json;



namespace Bank_Serialization
{
    public class SerializationUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Account { get; set; }
        public string BirthDate { get; set; }
        public string[] Deposits { get; set; }



        public SerializationUser() { }



        public SerializationUser(User user)
        {
            Username = user.Username;
            Password = user.Password;
            Name = user.Name;
            Surname = user.Surname;
            Account = user.Account;

            BirthDate = user.BirthDate.Json();

            List<string> deposits = new List<string>();
            foreach (LocalDeposit deposit in user.Deposits)
                deposits.Add(deposit.Title);
            Deposits = deposits.ToArray();
        }



        static public SerializationUser Deserialize(string json)
        {
            SerializationUser result = JsonSerializer.Deserialize<SerializationUser>(json);
            
            return result;
        }
    }
}
