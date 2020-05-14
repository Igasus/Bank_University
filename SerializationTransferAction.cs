using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Logic;
using System.Text.Json;

namespace Bank_Serialization
{
    class SerializationTransferAction
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
    }
}
