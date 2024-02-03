using System;

namespace OpenClosedPrinciple.Models;

class SavingsBankAccount : InterestBearingBankAccount
{
    public override decimal CalculateInterest()
    {
        // Some business logic
        throw new NotImplementedException();
    }
}
