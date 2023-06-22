

using Banking.Domain;

namespace Banking.UnitTests.BankAccount;
public class GoldCustomersGetABonusOnDeposits
{
    [Fact] 
    public void BonusIsApplied()
    {
        // given the context
        var account = new GoldAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        var expectedNewBalance = openingBalance + amountToDeposit + 10M;



        account.Deposit(amountToDeposit);



        Assert.Equal(expectedNewBalance, account.GetBalance());
    }
}
