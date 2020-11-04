

namespace Herança_e_polimorfismo.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        //protected e como private mas permite que outra sub classe modifique o dado
        public double Balance { get; protected set; }


        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        // conta normal paga um valor de 5 reais por saque
        //vitual incluido para que metodo seja sobrescrito
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
