using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface IUpdateQualificationUseCase
	{
		Task UpdateQualification(UpdateQualificationDTO qualification, int currentUserId);
	}
}
