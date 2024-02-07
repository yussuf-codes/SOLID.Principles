using System;
using InterfaceSegregationPrinciple.Models.IModels;

namespace InterfaceSegregationPrinciple.Models;

class CertificateDepositBankAccount : IInterestBearingBankAccount
{
    public Guid AccountNumber { get; set; }
    
    public decimal Balance { get; set; }
    public decimal CalculateInterest()
    {
        // Some business logic
        throw new NotImplementedException();
    }
    
    public void Deposit(int amount)
    {
        // Some business logic
        throw new NotImplementedException();
    }
}
