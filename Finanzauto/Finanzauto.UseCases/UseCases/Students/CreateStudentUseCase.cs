using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Extensions;
using Finanzauto.Domain.Interfaces;

namespace Finanzauto.Aplication.UseCases.Students
{
	internal class CreateStudentUseCase : ICreateStudentUseCase
	{
		private readonly IStudentRepository _studentRepository;

		public CreateStudentUseCase(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}

		public async Task CreateStudent(CreateStudentDTO student, int currentUserId)
		{
			student.Name.ValidateValue(nameof(student.Name));
			student.LastName.ValidateValue(nameof(student.LastName));
			student.Identification.ValidateValue(nameof(student.Identification));

			var createStudent = new Student
			{
				Name = student.Name,
				LastName = student.LastName,
				Identification = student.Identification,
				Email = student.Email,
				PhoneNumber = student.PhoneNumber,
				CreatedOn = DateTime.UtcNow,
				CreatedBy = currentUserId,
			};

			await _studentRepository.CreateStudent(createStudent);
		}
	}
}
