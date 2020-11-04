using Herança_e_polimorfismo.Entities;
using System;

namespace Herança_e_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            Account acc = new Account(1001, "alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "maria", 0.0, 500.0);

            //Upcasting

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob" , 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //Dowcasting

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }

            Console.WriteLine("________________________________");
            Console.WriteLine("Sobreposição ou sobrecrita");

            Account acc6 = new Account(1001, "alex", 500.0);
            Account acc7 = new SavingsAccount(1002, "Anna", 500.00, 0.01);

            acc6.Withdraw(10.0);
            acc7.Withdraw(10.0);

            Console.WriteLine(acc6.Balance);
            Console.WriteLine(acc7.Balance);
        }
    }
}
