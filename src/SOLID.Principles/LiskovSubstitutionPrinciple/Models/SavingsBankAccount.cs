using System;

namespace LiskovSubstitutionPrinciple.Models;

class SavingsBankAccount : WithdrawalBankAccount
{
    public override void Deposit(int amount)
    {
        // Some business logic
        throw new NotImplementedException();
    }

    public override void Withdraw(int amount)
    {
        // Some business logic
        throw new NotImplementedException();
    }
}
