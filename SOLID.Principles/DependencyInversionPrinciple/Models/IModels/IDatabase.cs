namespace DependencyInversionPrinciple.Models.IModels;

interface IDatabase
{
    int Create(object obj);
    object Read(int id);
    bool Update(int id, object obj);
    bool Delete(int id);
}
