

namespace Herança_e_polimorfismo.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        /* com virtual aplicado em account agora podemos sobrescrever o metodo para que
          SavingAccount nao pague 5 reais a cada saque.
         public override void Withdraw(double amount)
         {
             Balance -= amount;
         }
         */

        //Com base podemos usar um metodo ja implementado e acrecentar mais uma modificaçao a ele.
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }

    }
}
