namespace BRichards.Helper.MinimalApi.EndpointDefinition;

/// <summary>
/// Interface for structured minimal apis
/// </summary>
public interface IEndpointDefinition
{
    /// <summary>
    /// Method used to define endpoints
    /// </summary>
    /// <param name="app"></param>
    public void DefineEndpoints(WebApplication app);

    /// <summary>
    /// Method used to define services used by the endpoints
    /// </summary>
    /// <param name="services"></param>
    public void DefineServices(IServiceCollection services);
}
