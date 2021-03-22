using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task
{
    class Transaction
    {
        public Account Sender { get; set; }
        public Account Receiver { get; set; }
        public int Amount { get; set; }
        public String AdditionalInfo { get; set; }

        public Transaction() { }

        public Transaction(Account Sender, Account Receiver, int Amount,String AdditionlInfo)
        {
            this.Sender = Sender;
            this.Receiver = Receiver;
            this.Amount = Amount;
            this.AdditionalInfo = AdditionlInfo;
        }

        

        public void ShowInfo()
        {

        }
    }
}
