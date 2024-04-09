using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface IGetTeacherUseCase
	{
		Task<PaginateResponseDTO<TeacherDTO>> GetTeachers(QueryRequestDTO filters);
	}
}
