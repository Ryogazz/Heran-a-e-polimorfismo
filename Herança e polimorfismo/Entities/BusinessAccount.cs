

namespace Herança_e_polimorfismo.Entities
{

    //: serve para herdar os dados de uma classe
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            :base(number, holder,balance)
        { LoanLimit = loanLimit; }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
