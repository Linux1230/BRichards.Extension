namespace BRichards.Extension.Repositories;

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRepository<T>
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    T Create(T obj);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    void Update(T obj);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    void Delete(int id);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    T? GetById(int id);
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    List<T> GetAll();
}