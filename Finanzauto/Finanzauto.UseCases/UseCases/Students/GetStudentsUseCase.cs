using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Interfaces;

namespace Finanzauto.Aplication.UseCases.Students
{
	internal class GetStudentsUseCase : IGetStudentsUseCase
	{
		private readonly IStudentRepository _studentRepository;

		public GetStudentsUseCase(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}

		public async Task<PaginateResponseDTO<StudentDTO>> GetStudents(QueryRequestDTO filters)
		{
			var students = await _studentRepository.GetAllStudent(filters);
			var totalRecords = await _studentRepository.StudentsTotalRecordsAsync(filters);
			var pageCount = (int)Math.Ceiling(totalRecords / (decimal)filters.RowsPage);

			var result = new PaginateResponseDTO<StudentDTO>
			{
				Page = filters.Page,
				RowsPage = filters.RowsPage,
				TotalRecords = totalRecords,
				PageCount = pageCount,
				List = students.Select(x =>
				new StudentDTO
				{
					Id = x.Id,
					Name = x.Name,
					LastName = x.LastName,
					Identification = x.Identification,
					Email = x.Email,
					PhoneNumber = x.PhoneNumber,
					CreatedOn = x.CreatedOn,
				}),
			};

			return result;
		}
	}
}
