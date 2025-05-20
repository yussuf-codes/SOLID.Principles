using System;

namespace LiskovSubstitutionPrinciple.Models;

class CertificateDepositBankAccount : BankAccount
{
    public void Deposit(int amount)
    {
        // Some business logic
        throw new NotImplementedException();
    }
}
