using LiskovSubstitutionPrinciple.Models;

namespace LiskovSubstitutionPrinciple.Services;

class AutomatedTellerMachine
{
    void Withdraw(WithdrawalBankAccount withdrawalBankAccount, int amount)
    {
        withdrawalBankAccount.Withdraw(amount);
    }
    
    void Deposit(BankAccount bankAccount, int amount)
    {
        bankAccount.Deposit(amount);
    }
}
