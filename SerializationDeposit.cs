using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Logic;



namespace Bank_Serialization
{
    class SerializationDeposit
    {
        public string Title { get; set; }
        public double AnnualRate { get; set; }
        public int Duration { get; set; }
        public string[] LocalDeposits { get; set; }



        public SerializationDeposit() { }



        public SerializationDeposit(Deposit deposit)
        {
            Title = deposit.Title;
            AnnualRate = deposit.AnnualRate;
            Duration = deposit.Duration;

            List<string> localDeposits = new List<string>();
            foreach (LocalDeposit localDeposit in deposit.LocalDeposits)
                localDeposits.Add(localDeposit.Title);
            LocalDeposits = localDeposits.ToArray();
        }
    }
}
