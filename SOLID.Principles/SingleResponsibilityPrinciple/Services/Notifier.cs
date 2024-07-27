using System;
using SingleResponsibilityPrinciple.Models;

namespace SingleResponsibilityPrinciple.Services;

class Notifier(BankAccount bankAccount)
{
    private readonly BankAccount _bankAccount = bankAccount;
    
    public void SendEmail(string message)
    {
        // Some business logic
        throw new NotImplementedException();
    }
    
    public void SendSMS(string message)
    {
        // Some business logic
        throw new NotImplementedException();
    }
}
