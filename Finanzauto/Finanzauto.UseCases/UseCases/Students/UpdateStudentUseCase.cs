using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Extensions;
using Finanzauto.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzauto.Aplication.UseCases.Students
{
	internal class UpdateStudentUseCase : IUpdateStudentsUseCase
	{
		private readonly IStudentRepository _studentRepository;

		public UpdateStudentUseCase(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}

		public async Task UpdateStudent(UpdateStudentDTO student, int currentUserId)
		{
			student.Name.ValidateValue(nameof(student.Name));
			student.LastName.ValidateValue(nameof(student.LastName));
			student.Identification.ValidateValue(nameof(student.Email));

			var createStudent = new Student
			{
				Id = student.Id,
				Name = student.Name,
				LastName = student.LastName,
				Identification = student.Identification,
				Email = student.Email,
				PhoneNumber = student.PhoneNumber,
				ModifiedBy = currentUserId,
				ModifiedOn = DateTime.UtcNow,
			};

			await _studentRepository.UpdateStudent(createStudent);
		}
	}
}
