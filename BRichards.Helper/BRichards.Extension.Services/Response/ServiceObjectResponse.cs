namespace BRichards.Extension.Services.Response;

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public class ServiceObjectResponse<T> : ServiceResponse
{
    private T? _object;

    /// <summary>
    /// If object is null, State will be set to ServiceResponseState.Null,
    /// otherwise to ServiceResponseState.Success
    /// </summary>
    public T? Object
    {
        get => _object;
        set
        {
            if (value is not null)
            {
                State = ServiceResponseState.Success;
                _object = value;
                return;
            }

            State = ServiceResponseState.Null;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public ServiceObjectResponse() { }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="message"></param>
    /// <param name="state"></param>
    public ServiceObjectResponse(T? obj, string? message, ServiceResponseState state) :
        base(message, state)
    {
        Object = obj;
    }

    /// <summary>
    /// It will set the State to ServiceResponseState.Null
    /// </summary>
    /// <returns>bool</returns>
    public virtual bool IsNull()
    {
        if (Object is null)
        {
            State = ServiceResponseState.Null;
            return true;
        }
        return false;
    }

    /// <summary>
    /// It will set the State to ServiceResponseState.Success
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public virtual ServiceObjectResponse<T> SetObject(T? obj)
    {
        if (obj is not null)
        {
            State = ServiceResponseState.Success;
            _object = obj;
            return this;
        }
        State = ServiceResponseState.Null;
        return this;
    }
}