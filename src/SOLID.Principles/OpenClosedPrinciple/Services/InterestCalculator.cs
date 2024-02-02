using OpenClosedPrinciple.Models;

namespace OpenClosedPrinciple.Services;

class InterestCalculator(BankAccount bankAccount)
{
    private readonly BankAccount _bankAccount = bankAccount;
    
    public decimal CalculateInterest()
    {
        return _bankAccount.CalculateInterest();
    }
}
