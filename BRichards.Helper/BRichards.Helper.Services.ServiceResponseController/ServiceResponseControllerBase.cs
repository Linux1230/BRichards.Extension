using BRichards.Helper.Services.Response;
using Microsoft.AspNetCore.Mvc;

namespace BRichards.Helper.Services.ServiceResponseController;

public class ServiceResponseControllerBase : ControllerBase
{
    protected IActionResult GetActionResult(ServiceResponse response) =>
        response.State switch
        {
            ServiceResponseState.Success => Ok(),
            ServiceResponseState.Error => BadRequest(response.Message),
            ServiceResponseState.Null => NotFound(),
            ServiceResponseState.Invalid => UnprocessableEntity(),
            _ => BadRequest()
        };

    protected IActionResult GetActionResultObject<T>(ServiceObjectResponse<T> response) =>
        response.State switch
        {
            ServiceResponseState.Success => Ok(response.Object),
            ServiceResponseState.Error => BadRequest(response.Message),
            ServiceResponseState.Null => NotFound(),
            ServiceResponseState.Invalid => UnprocessableEntity(),
            _ => BadRequest()
        };
}
