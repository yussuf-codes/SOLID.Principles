namespace OpenClosedPrinciple.Models;

abstract class InterestBearingBankAccount : BankAccount
{
    public abstract decimal CalculateInterest();
}
