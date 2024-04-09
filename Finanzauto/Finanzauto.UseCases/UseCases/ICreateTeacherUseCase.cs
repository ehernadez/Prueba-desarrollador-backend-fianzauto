using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface ICreateTeacherUseCase
	{
		Task CreateTeacher(CreateTeacherDTO teacher, int currentUserId);
	}
}
