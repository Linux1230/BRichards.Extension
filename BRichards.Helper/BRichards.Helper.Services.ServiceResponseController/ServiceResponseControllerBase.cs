using BRichards.Helper.Services.Response;
using Microsoft.AspNetCore.Mvc;

namespace BRichards.Helper.Services.ServiceResponseController;

public class ServiceResponseControllerBase : ControllerBase
{
    protected IActionResult GetActionResult(ServiceResponse response)=>
        response.State switch
        {
             ServiceResponse.ServiceResponseState.Success => Ok(),
             ServiceResponse.ServiceResponseState.Error => BadRequest(response.Message),
             ServiceResponse.ServiceResponseState.Null => NotFound(),
             ServiceResponse.ServiceResponseState.Invalid => UnprocessableEntity(),
             _ => BadRequest()
        };

    protected IActionResult GetActionResultObject<T>(ServiceObjectResponse<T> response) =>
        response.State switch
        {
            ServiceResponse.ServiceResponseState.Success => Ok(response.Object),
            ServiceResponse.ServiceResponseState.Error => BadRequest(response.Message),
            ServiceResponse.ServiceResponseState.Null => NotFound(),
            ServiceResponse.ServiceResponseState.Invalid => UnprocessableEntity(),
            _ => BadRequest()
        };
}
