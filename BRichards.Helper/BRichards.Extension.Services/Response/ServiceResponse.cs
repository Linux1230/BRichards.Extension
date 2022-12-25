namespace BRichards.Extension.Services.Response;

public class ServiceResponse
{
    public string? Message { get; set; }
    public ServiceResponseState State { get; set; }

    public ServiceResponse() { }

    public ServiceResponse(string? message, ServiceResponseState state)
    {
        Message = message;
        State = state;
    }

    /// <summary>
    /// It will set the State to ServiceResponseState.Success
    /// <param name="obj"></param>
    /// <returns></returns>
    public virtual ServiceResponse SetSuccess(string message = "")
    {
        State = ServiceResponseState.Success;
        Message = message;
        return this;
    }

    /// <summary>
    /// It will set the State to ServiceResponseState.Invalid
    /// <param name="obj"></param>
    /// <returns></returns>
    public virtual ServiceResponse SetInvalid(string message = "")
    {
        State = ServiceResponseState.Invalid;
        Message = message;
        return this;
    }

    /// <summary>
    /// It will set the State to ServiceResponseState.Error
    /// <param name="obj"></param>
    /// <returns></returns>
    public virtual ServiceResponse SetError(string message = "")
    {
        State = ServiceResponseState.Error;
        Message = message;
        return this;
    }

    /// <summary>
    /// It will set the State to ServiceResponseState.Error
    /// <param name="obj"></param>
    /// <returns></returns>
    public virtual ServiceResponse SetNull(string message = "")
    {
        State = ServiceResponseState.Null;
        Message = message;
        return this;
    }
}