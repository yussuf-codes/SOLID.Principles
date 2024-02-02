using System;

namespace OpenClosedPrinciple.Models;

class CertificateDepositBankAccount : BankAccount
{
    public override decimal CalculateInterest()
    {
        // Some business logic
        throw new NotImplementedException();
    }
}
