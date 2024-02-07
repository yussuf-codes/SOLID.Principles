using DependencyInversionPrinciple.Models.IModels;

namespace DependencyInversionPrinciple.Models;

class Redis : IDatabase
{
    private readonly string _connectionString;
    
    public Redis(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    public int Create(object obj)
    {
        throw new System.NotImplementedException();
    }

    public object Read(int id)
    {
        throw new System.NotImplementedException();
    }

    public bool Update(int id, object obj)
    {
        throw new System.NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new System.NotImplementedException();
    }
}