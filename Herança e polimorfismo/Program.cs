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
        }
    }
}
