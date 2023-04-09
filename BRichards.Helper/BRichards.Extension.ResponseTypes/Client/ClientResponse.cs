namespace BRichards.Extension.ResponseTypes.Client;

/// <summary>
/// 
/// </summary>
public class ClientResponse
{
    /// <summary>
    /// 
    /// </summary>
    public bool IsSuccess { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string? Message { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int StatusCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ClientResponse()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="isSuccess"></param>
    /// <param name="message"></param>
    /// <param name="statusCode"></param>
    public ClientResponse(bool isSuccess, string? message, int statusCode)
    {
        IsSuccess = isSuccess;
        Message = message;
        StatusCode = statusCode;
    }
}
