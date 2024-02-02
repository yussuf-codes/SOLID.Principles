using System;
using InterfaceSegregationPrinciple.Models.IModels;

namespace InterfaceSegregationPrinciple.Models;

class CertificateDepositBankAccount : IBankAccount
{
    public Guid AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public void Deposit(int amount)
    {
        // Some business logic
        throw new NotImplementedException();
    }
}
