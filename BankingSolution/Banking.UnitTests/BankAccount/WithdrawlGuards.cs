

namespace Banking.UnitTests.BankAccount
{
    public class WithdrawlGuards
    {
        [Fact]
        public void OverdraftNotAllowed()
        {
            var account = new Account();
            var openingBalance = account.GetBalance();

            account.Withdrawl(openingBalance + .01m);

            Assert.Equal(openingBalance, account.GetBalance());
        }
    }
}
