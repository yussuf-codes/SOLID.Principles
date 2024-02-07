using DependencyInversionPrinciple.Models.IModels;

namespace DependencyInversionPrinciple.Models;

class MongoDB : IDatabase
{
    private readonly string _connectionString;
    
    public MongoDB(string connectionString)
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
