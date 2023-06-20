namespace Banking.Domain
{
    public class Account
    {
        private decimal _balance = 5000;
        public void Deposit(decimal amountToDeposit)
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
                return; 
            }
            _balance = _balance - amountToWithdrawl;
        }
    }
}