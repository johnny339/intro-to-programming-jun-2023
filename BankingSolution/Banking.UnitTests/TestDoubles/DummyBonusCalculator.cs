

namespace Banking.UnitTests.TestDoubles;
internal class DummyBonusCalculator : ICanCalculateBonuses
{
    public decimal CalculateBonusForDepositOn(decimal balance, decimal amountToDeposit)
    {
        return 0;
    }
}
