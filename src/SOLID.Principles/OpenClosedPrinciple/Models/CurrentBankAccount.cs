using System;

namespace OpenClosedPrinciple.Models;

class CurrentBankAccount : BankAccount
{
    public override decimal CalculateInterest()
    {
        // Some business logic
        throw new NotImplementedException();
    }
}
