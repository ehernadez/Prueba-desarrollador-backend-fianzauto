using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface IGetQualificationsUseCase
	{
		Task<PaginateResponseDTO<QualificationDTO>> GetQualifications(QueryRequestDTO filters);
	}
}
