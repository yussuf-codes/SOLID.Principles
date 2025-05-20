using OpenClosedPrinciple.Models;

namespace OpenClosedPrinciple.Services;

class InterestCalculator(InterestBearingBankAccount interestBearingBankAccount)
{
    private readonly InterestBearingBankAccount _interestBearingBankAccount = interestBearingBankAccount;

    public decimal CalculateInterest()
    {
        return _interestBearingBankAccount.CalculateInterest();
    }
}
