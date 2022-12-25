using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BRichards.Extension.MinimalApi.EndpointDefinition;

/// <summary>
/// Extension methodes used to register and add EndpointDefinitions to WebApplication using minimal apis
/// </summary>
public static class EndpointDefinitionExtensions
{
    /// <summary>
    /// This will Assembly scan, and add EndpointDefinitions to the service collection
    /// </summary>
    /// <param name="services"></param>
    public static void AddEndpointDefinitions(this IServiceCollection services)
    {
        var endpointDefinitions = new List<IEndpointDefinition>();

        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            endpointDefinitions.AddRange(
                assembly.ExportedTypes.Where(x => typeof(IEndpointDefinition).IsAssignableFrom(x)
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
