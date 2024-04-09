using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface IDeleteQualificationUseCase
	{
		Task DeleteQualification(DeleteDTO qualification, int currentUserId);
	}
}
