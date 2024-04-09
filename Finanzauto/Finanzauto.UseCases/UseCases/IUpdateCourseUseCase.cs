using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface IUpdateCourseUseCase
	{
		Task UpdateCourse(UpdateCourseDTO course, int currentUserId);
	}
}
