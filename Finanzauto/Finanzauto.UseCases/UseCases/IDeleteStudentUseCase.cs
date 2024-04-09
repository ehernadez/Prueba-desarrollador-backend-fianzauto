using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface IDeleteStudentUseCase
	{
		Task DeleteStudent(DeleteDTO student, int currentUserId);
	}
}
