using BRichards.Extension.Services.Response;
using Microsoft.AspNetCore.Mvc;

namespace BRichards.Extension.Services.ServiceResponseController;

/// <summary>
/// 
/// </summary>
public class ServiceResponseControllerBase : ControllerBase
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="response"></param>
    /// <returns></returns>
    protected IActionResult GetActionResult(ServiceResponse response) =>
        response.State switch
        {
            ServiceResponseState.Success => Ok(),
            ServiceResponseState.Error => BadRequest(response.Message),
            ServiceResponseState.Null => NotFound(),
            ServiceResponseState.Invalid => UnprocessableEntity(),
            _ => BadRequest()
        };

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="response"></param>
    /// <returns></returns>
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
