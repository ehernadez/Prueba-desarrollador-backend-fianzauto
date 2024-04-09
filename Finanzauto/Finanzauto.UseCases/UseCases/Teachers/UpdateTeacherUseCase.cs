using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Extensions;
using Finanzauto.Domain.Interfaces;

namespace Finanzauto.Aplication.UseCases.Teachers
{
	internal class UpdateTeacherUseCase : IUpdateTeacherUseCase
	{
		private readonly ITeacherRepository _teacherRepository;

		public UpdateTeacherUseCase(ITeacherRepository teacherRepository)
		{
			_teacherRepository = teacherRepository;
		}

		public async Task UpdateTeacher(UpdateTeacherDTO teacher, int currentUserId)
		{
			teacher.Name.ValidateValue(nameof(teacher.Name));
			teacher.LastName.ValidateValue(nameof(teacher.LastName));
			teacher.Email.ValidateValue(nameof(teacher.Email));

			var createTeacher = new Teacher
			{
				Id = teacher.Id,
				Name = teacher.Name,
				LastName = teacher.LastName,
				Email = teacher.Email,
				PhoneNumber = teacher.PhoneNumber,
				ModifiedBy = currentUserId,
				ModifiedOn = DateTime.UtcNow,
			};

			await _teacherRepository.UpdateTeacher(createTeacher);
		}
	}
}
