using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface IGetStudentsUseCase
	{
		Task<PaginateResponseDTO<StudentDTO>> GetStudents(QueryRequestDTO filters);

	}
}
