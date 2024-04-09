using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Interfaces;

namespace Finanzauto.Aplication.UseCases.Students
{
	internal class DeleteStudentUseCase : IDeleteStudentUseCase
	{
		private readonly IStudentRepository _studentRepository;

		public DeleteStudentUseCase(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}

		public async Task DeleteStudent(DeleteDTO student, int currentUserId)
		{
			var deleteStudent = new Student
			{
				Id = student.Id,
				ModifiedBy = currentUserId,
				ModifiedOn = DateTime.UtcNow,
			};

			await _studentRepository.DeleteStudent(deleteStudent);
		}
	}
}
