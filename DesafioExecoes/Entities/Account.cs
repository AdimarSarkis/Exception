using DesafioExecoes.Entities.Exceptions;

namespace DesafioExecoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }
        

        public Account() {}
        public Account(int number,string holder, double balance, double withdrawlimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withdrawlimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainException ("Withdraw error: The amount exceeds withdraw limit");
            }
            if(amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balace");
            }
            Balance -= amount;
        }
    }
}
