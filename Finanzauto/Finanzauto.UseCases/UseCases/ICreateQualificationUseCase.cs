using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface ICreateQualificationUseCase
	{
		Task CreateQualification(CreateQualificationDTO qualification, int currentUserId);
	}
}
