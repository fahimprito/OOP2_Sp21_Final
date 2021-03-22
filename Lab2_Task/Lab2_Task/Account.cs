using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task
{
    class Account
    {
        private string accName;
        private string accid;
        private int balance;

        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }

        public string Accid
        {
            set { accid = value; }
            get { return accid; }
        }

        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public int TotalTransaction { get; set; }

        Transaction[] transactionlist;
        public Account()
        {
            transactionlist = new Transaction[10];
        }

        public void Addtransaction(Transaction transaction)
        {
            transactionlist[TotalTransaction++] = transaction;
        }

        public Account(string accName, string accid, int balance)
        {
            this.accName = accName;
            this.accid = accid;
            this.balance = balance;
        }
        public void Deposit(int amount)
        {
            balance = balance + amount;
            {
                Console.WriteLine("{0}TK Added in your Account", amount);
                Console.WriteLine("New Balance {0}TK", balance);
                Console.WriteLine("");
            }

        }
        public void Withdraw(int amount)
        {
            balance = balance - amount;
            {
                Console.WriteLine("{0}TK Money withdraw from your Account", amount);
                Console.WriteLine("New Balance {0}TK", balance);
                Console.WriteLine("");
            }
        }


        public void transfer(int amount, Account acc)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
                acc.balance = amount + balance;
                Console.WriteLine("Balance Transfered {0}TK", amount);
                Console.WriteLine("New Balance {0}TK", balance);
            }
            else
            {
                Console.WriteLine("Not Sufficient Balance");
            }
        }



    }
}
