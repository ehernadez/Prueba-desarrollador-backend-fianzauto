using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Extensions;
using Finanzauto.Domain.Interfaces;

namespace Finanzauto.Aplication.UseCases.Teachers
{
	internal class CreateTeacherUseCase : ICreateTeacherUseCase
	{
		private readonly ITeacherRepository _teacherRepository;

		public CreateTeacherUseCase(ITeacherRepository teacherRepository)
		{
			_teacherRepository = teacherRepository;
		}

		public async Task CreateTeacher(CreateTeacherDTO teacher, int currentUserId)
		{
			teacher.Name.ValidateValue(nameof(teacher.Name));
			teacher.LastName.ValidateValue(nameof(teacher.LastName));
			teacher.Email.ValidateValue(nameof(teacher.Email));

			var createTeacher = new Teacher
			{
				Name = teacher.Name,
				LastName = teacher.LastName,
				Email = teacher.Email,
				PhoneNumber = teacher.PhoneNumber,
				CreatedOn = DateTime.UtcNow,
				CreatedBy = currentUserId,
			};

			await _teacherRepository.CreateTeacher(createTeacher);
		}
	}
}
