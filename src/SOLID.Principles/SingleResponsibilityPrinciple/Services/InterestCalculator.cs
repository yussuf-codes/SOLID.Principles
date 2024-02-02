using System;
using SingleResponsibilityPrinciple.Models;

namespace SingleResponsibilityPrinciple.Services;

class InterestCalculator(BankAccount bankAccount)
{
    private readonly BankAccount _bankAccount = bankAccount;

    public decimal CalculateInterest()
    {
        // Some business logic
        throw new NotImplementedException();
    }
}
