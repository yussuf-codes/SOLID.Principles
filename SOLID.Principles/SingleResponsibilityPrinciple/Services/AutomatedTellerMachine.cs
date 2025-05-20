using System;
using SingleResponsibilityPrinciple.Models;

namespace SingleResponsibilityPrinciple.Services;

class AutomatedTellerMachine(BankAccount bankAccount)
{
    private readonly BankAccount _bankAccount = bankAccount;

    public void Deposit(decimal amount)
    {
        // Some business logic
        throw new NotImplementedException();
    }

    public void Withdraw(decimal amount)
    {
        // Some business logic
        throw new NotImplementedException();
    }

    public void Transfer(BankAccount bankAccount, decimal amount)
    {
        // Some business logic
        throw new NotImplementedException();
    }
}
