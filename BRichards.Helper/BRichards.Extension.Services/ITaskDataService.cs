namespace BRichards.Extension.Services;

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ITaskDataService<T>
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Task<IEnumerable<T>> GetList();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Task<T> GetById(int id);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public Task<T> Create(T obj);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public Task Update(T obj);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public Task Delete(T obj);
}