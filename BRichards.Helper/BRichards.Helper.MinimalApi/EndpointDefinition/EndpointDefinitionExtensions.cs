namespace BRichards.Helper.MinimalApi.EndpointDefinition;

/// <summary>
/// Extension methodes used to register and add EndpointDefinitions to WebApplication using minimal apis
/// </summary>
public static class EndpointDefinitionExtensions
{
    /// <summary>
    /// This will Assembly scan, and add EndpointDefinitions to the service collection
    /// </summary>
    /// <param name="services"></param>
    /// <param name="scanMarkers"></param>
    public static void AddEndpointDefinitions(this IServiceCollection services,
                                              params Type[] scanMarkers)
    {
        var endpointDefinitions = new List<IEndpointDefinition>();

        foreach (var marker in scanMarkers)
        {
            endpointDefinitions.AddRange(
                marker.Assembly.ExportedTypes
                    .Where(x => typeof(IEndpointDefinition).IsAssignableFrom(x)
                                && !x.IsInterface
                                && !x.IsAbstract)
                    .Select(Activator.CreateInstance)
                    .Cast<IEndpointDefinition>()
            );
        }

        foreach (var endpointDefinition in endpointDefinitions)
        {
            endpointDefinition.DefineServices(services);
        }

        services.AddSingleton(endpointDefinitions as IReadOnlyCollection<IEndpointDefinition>);
    }

    /// <summary>
    /// This will add all the endpoint definition's endpoints to the application using minimal api
    /// </summary>
    /// <param name="app"></param>
    public static void UseEndpointDefinitions(this WebApplication app)
    {
        var definitions = app.Services.GetRequiredService<IReadOnlyCollection<IEndpointDefinition>>();

        foreach (var endpointDefinition in definitions)
        {
            endpointDefinition.DefineEndpoints(app);
        }
    }
}
