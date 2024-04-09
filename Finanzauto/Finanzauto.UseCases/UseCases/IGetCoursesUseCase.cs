using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface IGetCoursesUseCase
	{
		Task<PaginateResponseDTO<CourseDTO>> GetCourses(QueryRequestDTO filters);
	}
}
