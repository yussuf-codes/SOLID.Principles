using System;

namespace OpenClosedPrinciple.Models;

abstract class BankAccount
{
    public Guid AccountNumber { get; set; }
    public decimal Balance { get; set; }
}
