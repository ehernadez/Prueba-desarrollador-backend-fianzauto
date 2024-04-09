using Finanzauto.Domain.Interfaces;
using Finanzauto.Infraestructure.DataContext;
using Finanzauto.Infraestructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data.SqlClient;

namespace Finanzauto.Infraestructure
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<IFinanzautoContext>(provider =>
			{
				var connectionString = configuration.GetConnectionString("FinanzautoConnectionString");
				var connection = new SqlConnection(connectionString);
				connection.Open();
				return new FinanzautoContext(connection);
			});
			services.AddScoped<ICourseRepository, CourseRepository>();
			services.AddScoped<IAuthRepository, AuthRepository>();
			services.AddScoped<IStudentRepository, StudentRepository>();
			services.AddScoped<ITeacherRepository, TeacherRepository>();
			services.AddScoped<IStudentRepository, StudentRepository>();
			services.AddScoped<IQualificationRepository, QualificationRepository>();

			return services;
		}
	}
}
