using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Logic;



namespace Bank_Serialization
{
    class SerializationUser
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
    }
}
