using System;

namespace LiskovSubstitutionPrinciple.Models;

class CurrentBankAccount : WithdrawalBankAccount
{
    public override void Withdraw(int amount)
    {
        // Some business logic
        throw new NotImplementedException();
    }
}
