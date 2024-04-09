using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface IUpdateTeacherUseCase
	{
		Task UpdateTeacher(UpdateTeacherDTO teacher, int currentUserId);
	}
}
