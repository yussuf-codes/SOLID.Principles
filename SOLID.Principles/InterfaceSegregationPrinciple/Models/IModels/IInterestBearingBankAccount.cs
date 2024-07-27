namespace InterfaceSegregationPrinciple.Models.IModels;

interface IInterestBearingBankAccount : IBankAccount
{
    decimal CalculateInterest();
}
