using System;

namespace InterfaceSegregationPrinciple.Models.IModels;

interface IBankAccount : IDepositable
{
    public Guid AccountNumber { get; set; }
    decimal Balance { get; set; }
}
