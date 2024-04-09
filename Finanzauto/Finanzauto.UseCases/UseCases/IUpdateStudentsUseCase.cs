using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface IUpdateStudentsUseCase
	{
		Task UpdateStudent(UpdateStudentDTO student, int currentUserId);
	}
}
