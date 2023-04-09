using BRichards.Extension.Services.Response;

namespace BRichards.Extension.Services;

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IObjectResponseService<T>
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public ServiceObjectResponse<IEnumerable<T>> GetAll();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public ServiceObjectResponse<T> GetById(int id);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public ServiceObjectResponse<T> Create(T obj);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public ServiceResponse Update(T obj);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public ServiceResponse Delete(int id);
}