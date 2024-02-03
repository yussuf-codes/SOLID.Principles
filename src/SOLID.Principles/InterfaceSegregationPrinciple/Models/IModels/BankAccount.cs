using System;

namespace InterfaceSegregationPrinciple.Models.IModels;

interface IBankAccount : IDepositable
{
    Guid AccountNumber { get; set; }
    decimal Balance { get; set; }
}
