namespace BRichards.Extension.Services.Response;

/// <summary>
/// 
/// </summary>
public class ServiceResponse
{
    /// <summary>
    /// 
    /// </summary>
    public string? Message { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public ServiceResponseState State { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ServiceResponse() { }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <param name="state"></param>
    public ServiceResponse(string? message, ServiceResponseState state)
    {
        Message = message;
        State = state;
    }

    /// <summary>
    /// It will set the State to ServiceResponseState.Success
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public virtual ServiceResponse SetSuccess(string message = "")
    {
        State = ServiceResponseState.Success;
        Message = message;
        return this;
    }

    /// <summary>
    /// It will set the State to ServiceResponseState.Invalid
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public virtual ServiceResponse SetInvalid(string message = "")
    {
        State = ServiceResponseState.Invalid;
        Message = message;
        return this;
    }

    /// <summary>
    /// It will set the State to ServiceResponseState.Error
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public virtual ServiceResponse SetError(string message = "")
    {
        State = ServiceResponseState.Error;
        Message = message;
        return this;
    }

    /// <summary>
    /// It will set the State to ServiceResponseState.Error
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public virtual ServiceResponse SetNull(string message = "")
    {
        State = ServiceResponseState.Null;
        Message = message;
        return this;
    }
}