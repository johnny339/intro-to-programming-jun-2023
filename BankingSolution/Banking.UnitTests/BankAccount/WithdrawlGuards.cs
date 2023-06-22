

using Banking.Domain;

namespace Banking.UnitTests.BankAccount
{
    public class WithdrawlGuards
    {
        [Fact]
        public void OverdraftNotAllowed()
        {
            var account = new Account();
            var openingBalance = account.GetBalance();

            try
            {
                account.Withdrawl(openingBalance + .01m);
            }
            catch (OverdraftException)
            {

               /// ignore here
            }

            Assert.Equal(openingBalance, account.GetBalance());
        }

        [Fact]  
        public void OverdraftThrowsException()
        {
            var account = new Account();
            var openingBalance = account.GetBalance();

            Assert.Throws<OverdraftException>(
            () => account.Withdrawl(openingBalance + .01M));
        }
    }
}
