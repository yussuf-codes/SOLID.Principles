using System;
using InterfaceSegregationPrinciple.Models.IModels;

namespace InterfaceSegregationPrinciple.Models;

class SavingsBankAccount : IRegularBankAccount, IInterestBearingBankAccount
{
    public Guid AccountNumber { get; set; }

    public decimal Balance { get; set; }

    public decimal CalculateInterest()
    {
        throw new NotImplementedException();
    }

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
