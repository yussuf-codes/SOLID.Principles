using LiskovSubstitutionPrinciple.Models;

namespace LiskovSubstitutionPrinciple.Services;

class AutomatedTellerMachine
{
    public void Deposit(BankAccount bankAccount, int amount)
    {
        bankAccount.Deposit(amount);
    }

    public void Withdraw(WithdrawalBankAccount withdrawalBankAccount, int amount)
    {
        withdrawalBankAccount.Withdraw(amount);
    }
}
