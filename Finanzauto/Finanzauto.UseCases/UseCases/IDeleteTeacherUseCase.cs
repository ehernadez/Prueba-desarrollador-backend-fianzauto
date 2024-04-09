using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface IDeleteTeacherUseCase
	{
		Task DeleteTeacher(DeleteDTO teacher, int currentUserId);
	}
}
