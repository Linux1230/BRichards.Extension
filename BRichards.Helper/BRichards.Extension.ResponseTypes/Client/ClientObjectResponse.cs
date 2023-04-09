namespace BRichards.Extension.ResponseTypes.Client;

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public class ClientObjectResponse<T> : ClientResponse
{
    /// <summary>
    /// 
    /// </summary>
    public T? SentObject { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ClientObjectResponse()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="isSuccess"></param>
    /// <param name="message"></param>
    /// <param name="statusCode"></param>
    public ClientObjectResponse(bool isSuccess, string? message, int statusCode) :
        base(isSuccess, message, statusCode)
    {

    }
}
