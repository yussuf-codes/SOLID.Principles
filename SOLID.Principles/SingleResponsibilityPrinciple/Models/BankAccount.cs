using System;

namespace SingleResponsibilityPrinciple.Models;

class BankAccount
{
    public Guid AccountNumber { get; set; }
    public decimal Balance { get; set; }
    public decimal InterestRate { get; set; }
    public string Email { get; set; }
    public string MobileNumber { get; set; }
}
