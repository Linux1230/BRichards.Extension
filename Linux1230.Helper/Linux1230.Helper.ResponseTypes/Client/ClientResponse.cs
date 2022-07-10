namespace Linux1230.Helper.ResponseTypes.Client;

public class ClientResponse
{
    public bool IsSuccess { get; set; }
    public string? Message { get; set; }
    public int StatusCode { get; set; }

    public ClientResponse()
    {

    }

    public ClientResponse(bool isSuccess, string? message, int statusCode)
    {
        IsSuccess = isSuccess;
        Message = message;
        StatusCode = statusCode;
    }
}
