

namespace Banking.UnitTests.BankAccount
{
    public class MakingWithdrawls
    {
        [Fact]
        public void MakingAWithdrawlDecreasesTheBalance()
        {
            //given
            // If I have an account and I want to withdraw 100
            Account account = new Account();
            decimal openingBalance = account.GetBalance();
            decimal amountToWithdrawl = 100m;

            //when I do the withddrawl?
            account.Withdrawl(amountToWithdrawl);

            //then
            // Then - I can verify it worked if the new balance is 100 less than the balance
            //        was before.
            Assert.Equal(openingBalance - amountToWithdrawl, account.GetBalance());
        }

        [Fact]
        public void CanTakeFullBalance()
        {
            var account = new Account();
            var openingBalance = account.GetBalance();



            account.Withdrawl(openingBalance);



            Assert.Equal(0, account.GetBalance());
        }
    }
}
