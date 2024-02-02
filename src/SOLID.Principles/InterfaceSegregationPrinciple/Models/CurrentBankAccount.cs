using System;
using InterfaceSegregationPrinciple.Models.IModels;

namespace InterfaceSegregationPrinciple.Models;

class CurrentBankAccount : IRegularBankAccount
{
    public Guid AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public void Deposit(int amount)
    {
        // Some business logic
        throw new NotImplementedException();
    }

    public void Withdraw(int amount)
    {
        // Some business logic
        throw new NotImplementedException();
    }
}
