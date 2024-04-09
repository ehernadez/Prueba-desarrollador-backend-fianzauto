using Finanzauto.Aplication.UseCases;
using Finanzauto.Domain.Dtos;
using Finanzauto.Gateway;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

IConfiguration configuration = new ConfigurationBuilder()
	.AddInMemoryCollection(new[]
	{
	    new KeyValuePair<string, string>("ConnectionStrings:FinanzautoConnectionString", "Server=HERNANDEZ\\SQLEXPRESS;Database=Finanzauto;User Id=sa;Password=Edgar2130;")
    })
    .Build();

var s = configuration.GetConnectionString("FinanzautoConnectionString");

var serviceProvider = new ServiceCollection()
    .AddDependencies(configuration)
    .BuildServiceProvider();

// Obtener el servicio IFinanzautoContext
//var finanzautoContext = serviceProvider.GetRequiredService<IFinanzautoContext>();
// Usar el contexto de la base de datos
//var isConnected = await finanzautoContext.GetSingleValueAsync<string>(sqlStatement);

var create = serviceProvider.GetRequiredService<ICreateCourseUseCase>();

var obj = new CreateCourseDTO
{
	Name = "Prueba",
};

try
{
await create.CreateCourse(obj, 1);

}
catch (Exception e)
{

	throw;
}



Console.WriteLine($"La conexión a la base de datos es exitosa. ");
