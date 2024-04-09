using Finanzauto.Aplication.UseCases;
using Finanzauto.Aplication.UseCases.Authentication;
using Finanzauto.Aplication.UseCases.Courses;
using Finanzauto.Aplication.UseCases.Qualifications;
using Finanzauto.Aplication.UseCases.Students;
using Finanzauto.Aplication.UseCases.Teachers;
using Microsoft.Extensions.DependencyInjection;

namespace Finanzauto.Aplication
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
		{
			services.AddTransient<IAuthenticationUseCase, AuthenticationUseCase>();
			services.AddTransient<ICreateCourseUseCase, CreateCourseUseCase>();
			services.AddTransient<IGetCoursesUseCase, GetCoursesUseCase>();
			services.AddTransient<IUpdateCourseUseCase, UpdateCourseUseCase>();
			services.AddTransient<IDeleteCourseUseCase, DeleteCourseUseCase>();
			services.AddTransient<ICreateTeacherUseCase, CreateTeacherUseCase>();
			services.AddTransient<IGetTeacherUseCase, GetTeacherUseCase>();
			services.AddTransient<IUpdateTeacherUseCase, UpdateTeacherUseCase>();
			services.AddTransient<IDeleteTeacherUseCase, DeleteTeacherUseCase>();
			services.AddTransient<ICreateStudentUseCase, CreateStudentUseCase>();
			services.AddTransient<IGetStudentsUseCase, GetStudentsUseCase>();
			services.AddTransient<IUpdateStudentsUseCase, UpdateStudentUseCase>();
			services.AddTransient<IDeleteStudentUseCase, DeleteStudentUseCase>();
			services.AddTransient<ICreateQualificationUseCase, CreateQualificationUseCase>();
			services.AddTransient<IDeleteQualificationUseCase, DeleteQualificationUseCase>();
			services.AddTransient<IGetQualificationsUseCase, GetQualificationsUseCase>();
			services.AddTransient<IUpdateQualificationUseCase, UpdateQualificationUseCase>();

			return services;
		}
	}
}
