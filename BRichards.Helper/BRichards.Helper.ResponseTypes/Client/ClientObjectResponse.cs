namespace BRichards.Helper.ResponseTypes.Client;

public class ClientObjectResponse<T> : ClientResponse
{
    public T? SentObject { get; set; }

    public ClientObjectResponse()
    {

    }

    public ClientObjectResponse(bool isSuccess, string? message, int statusCode) :
        base(isSuccess, message, statusCode)
    {

    }
}
