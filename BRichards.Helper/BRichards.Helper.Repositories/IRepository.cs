namespace BRichards.Helper.Repositories;

public interface IRepository<T>
{
    T Create(T obj);
    void Update(T obj);
    void Delete(int id);
    T? GetById(int id);
    List<T> GetAll();
}