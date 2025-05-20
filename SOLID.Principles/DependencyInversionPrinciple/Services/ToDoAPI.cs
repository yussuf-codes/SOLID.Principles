using DependencyInversionPrinciple.Models;
using DependencyInversionPrinciple.Models.IModels;

namespace DependencyInversionPrinciple.Services;

class ToDoAPI
{
    private readonly IDatabase _database;

    public ToDoAPI(IDatabase database)
    {
        _database = database;
    }

    public ToDo Get(int id)
    {
        return (ToDo)_database.Read(id);
    }

    public int Post(ToDo toDo)
    {
        return _database.Create(toDo);
    }

    public bool Put(int id, ToDo toDo)
    {
        return _database.Update(id, toDo);
    }

    public bool Delete(int id)
    {
        return _database.Delete(id);
    }
}
