using System;

namespace LiskovSubstitutionPrinciple.Models;

abstract class BankAccount
{
    public Guid AccountNumber { get; set; }
    public decimal Balance { get; set; }
    public virtual void Deposit(decimal amount)
    {
        if (amount < 0)
            return;
        Balance += amount;
    }
}
