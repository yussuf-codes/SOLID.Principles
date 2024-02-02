using System;

namespace LiskovSubstitutionPrinciple.Models;

abstract class BankAccount
{
    public Guid AccountNumber { get; set; }
    public decimal Balance { get; set; }
    public abstract void Deposit(int amount);
}
