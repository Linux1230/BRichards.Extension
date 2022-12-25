using BRichards.Extension.Services.Response;

namespace BRichards.Extension.Services;

public interface IObjectResponseService<T>
{
    public ServiceObjectResponse<IEnumerable<T>> GetAll();
    public ServiceObjectResponse<T> GetById(int id);
    public ServiceObjectResponse<T> Create(T obj);
    public ServiceResponse Update(T obj);
    public ServiceResponse Delete(int id);
}