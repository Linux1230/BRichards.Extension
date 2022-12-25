namespace BRichards.Extension.Services;

public interface ITaskDataService<T>
{
    public Task<IEnumerable<T>> GetList();
    public Task<T> GetById(int id);
    public Task<T> Create(T obj);
    public Task Update(T obj);
    public Task Delete(T obj);
}