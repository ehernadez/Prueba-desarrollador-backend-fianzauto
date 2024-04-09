using Finanzauto.Aplication;
using Finanzauto.Infraestructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Finanzauto.Gateway
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddRepositories(configuration);
			services.AddUseCasesServices();

			return services;
		}
	}
}
