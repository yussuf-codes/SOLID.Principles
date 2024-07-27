using System;

namespace OpenClosedPrinciple.Models;

class CertificateDepositBankAccount : InterestBearingBankAccount
{
    public override decimal CalculateInterest()
    {
        // Some business logic
        throw new NotImplementedException();
    }
}
