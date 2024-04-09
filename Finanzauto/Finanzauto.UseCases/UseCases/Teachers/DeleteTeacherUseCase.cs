using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Interfaces;

namespace Finanzauto.Aplication.UseCases.Teachers
{
	internal class DeleteTeacherUseCase : IDeleteTeacherUseCase
	{
		private readonly ITeacherRepository _teacherRepository;

		public DeleteTeacherUseCase(ITeacherRepository teacherRepository)
		{
			_teacherRepository = teacherRepository;
		}

		public async Task DeleteTeacher(DeleteDTO teacher, int currentUserId)
		{
			var deleteTeacher = new Teacher
			{
				Id = teacher.Id,
				ModifiedBy = currentUserId,
				ModifiedOn = DateTime.UtcNow,
			};

			await _teacherRepository.DeleteTeacher(deleteTeacher);
		}
	}
}
