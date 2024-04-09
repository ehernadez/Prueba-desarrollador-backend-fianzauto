using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface IDeleteCourseUseCase
	{
		Task DeleteCourse(DeleteDTO course, int currentUserId);
	}
}
