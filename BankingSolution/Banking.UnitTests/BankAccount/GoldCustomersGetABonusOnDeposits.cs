

namespace Banking.UnitTests.BankAccount;
public class GoldCustomersGetABonusOnDeposits
{
    [Fact] 
    public void BonusIsApplied()
    {
        // given 
        // the context for this test
        var account = new Account();
        account.AccountType = LoyaltyLevel.Gold;
        var openingBalance = account.GetBalance(); //query 
        var amountToDeposit = 100m;
        var expectedNewBalance = openingBalance + amountToDeposit + 10m;

        // when - what are we testing
        account.Deposit(amountToDeposit);

        //then - how do we know it worked?
        Assert.Equal(expectedNewBalance, account.GetBalance());


    }
}