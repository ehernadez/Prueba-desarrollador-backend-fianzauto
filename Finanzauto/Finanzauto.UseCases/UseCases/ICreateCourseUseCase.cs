using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface ICreateCourseUseCase
	{
		Task CreateCourse(CreateCourseDTO course, int currentUserId);
	}
}
