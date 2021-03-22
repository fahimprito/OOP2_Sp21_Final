using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Fahim", "39488", 50000);
            Account a2 = new Account("Mojumder", "88493", 50000);

            a1.Withdraw(5000);
            a2.Deposit(1000);

            a1.transfer( 10000,a2);
            a2.transfer(20000, a1);

            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~Transaction~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            
            a1.ShowTransaction();
            a1.ShowInfo();
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~Transaction~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            a2.ShowTransaction();
            
            a2.ShowInfo();

        }
    }
}
