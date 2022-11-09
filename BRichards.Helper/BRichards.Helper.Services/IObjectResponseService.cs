using BRichards.Helper.Services.Response;

namespace BRichards.Helper.Services;

public interface IObjectResponseService<T>
{
    public ServiceObjectResponse<IEnumerable<T>> GetAll();
    public ServiceObjectResponse<T> GetById(int id);
    public ServiceObjectResponse<T> Create(T obj);
    public ServiceResponse Update(T obj);
    public ServiceResponse Delete(int id);
}