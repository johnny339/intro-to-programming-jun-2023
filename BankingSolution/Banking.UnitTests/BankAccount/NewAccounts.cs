



namespace Banking.UnitTests.BankAccount
{
    public class NewAccounts
    {
        [Fact]
        public void NewAccountsHaveCorrectBalance()
        {
            //given
            Account account = new Account();
            //when
            decimal balance = account.GetBalance();
            //then
            Assert.Equal(5000, balance);
        }
    }
}
