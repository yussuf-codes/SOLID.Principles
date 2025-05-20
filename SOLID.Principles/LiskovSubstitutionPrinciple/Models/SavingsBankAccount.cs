using System;

namespace LiskovSubstitutionPrinciple.Models;

class SavingsBankAccount : WithdrawalBankAccount
{
    public override void Withdraw(int amount)
    {
        // Some business logic
        throw new NotImplementedException();
    }
}
