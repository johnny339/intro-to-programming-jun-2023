namespace Banking.Domain
{
    public class Account
    {
        private decimal _balance = 5000;
        public virtual void Deposit(decimal amountToDeposit) // 'virtual' is used to allow a method to be modified
        {
            _balance = _balance + amountToDeposit;
        }

        public decimal GetBalance()
        {
            return _balance;
        }



        public void Withdrawl(decimal amountToWithdrawl)
        {
            if (amountToWithdrawl > _balance)
            {
                throw new OverdraftException();
            }
            _balance -= amountToWithdrawl;
        }
    }
}