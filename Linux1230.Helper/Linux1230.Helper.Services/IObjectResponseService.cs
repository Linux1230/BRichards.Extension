using Linux1230.Helper.Services.Response;

namespace Linux1230.Helper.Services
{
    public interface IObjectResponseService<T>
    {
        public ServiceObjectResponse<IEnumerable<T>> GetList();
        public ServiceObjectResponse<T> GetById(int id);
        public ServiceObjectResponse<T> Create(T obj);
        public ServiceResponse Update(T obj);
        public ServiceResponse Delete(T obj);
    }
}