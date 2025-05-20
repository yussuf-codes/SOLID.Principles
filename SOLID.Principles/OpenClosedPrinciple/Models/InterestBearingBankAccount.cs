namespace OpenClosedPrinciple.Models;

abstract class InterestBearingBankAccount : BankAccount
{
    public decimal InterestRate { get; set; }
    public abstract decimal CalculateInterest();
}
