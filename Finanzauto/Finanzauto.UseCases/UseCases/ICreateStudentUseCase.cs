using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface ICreateStudentUseCase
	{
		Task CreateStudent(CreateStudentDTO student, int currentUserId);
	}
}
