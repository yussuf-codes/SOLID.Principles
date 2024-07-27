namespace LiskovSubstitutionPrinciple.Models;

abstract class WithdrawalBankAccount : BankAccount
{
    public abstract void Withdraw(int amount);
}
