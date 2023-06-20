

namespace Banking.UnitTests.BankAccount
{
    public class MakingDeposits
    {
        [Fact]
        public void DepositIncreasesBalance()
        {
            //given
            // If I have an account and I want to deposit 100
            Account account = new Account();
            decimal openingBalance = account.GetBalance();
            decimal amountToDeposit = 100m;

            //when I do the deposit
            account.Deposit(amountToDeposit);

            //then
            // Then - I can verify it worked if the new balance is 100 more than the balance
            //        was before.
            Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());

        }
    }
}
