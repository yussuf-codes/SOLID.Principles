using DependencyInversionPrinciple.Models;
using DependencyInversionPrinciple.Models.IModels;
using DependencyInversionPrinciple.Services;

namespace DependencyInversionPrinciple;

public class Client
{
    private static void Main()
    {
        IDatabase database1 = new PostgreSQL("PostgreSQL connection string");
        IDatabase database2 = new MongoDB("MongoDB connection string");

        ToDoAPI toDoApi1 = new ToDoAPI(database1);
        ToDoAPI toDoApi2 = new ToDoAPI(database2);
    }
}
