using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Interfaces;

namespace Finanzauto.Aplication.UseCases.Teachers
{
	internal class GetTeacherUseCase : IGetTeacherUseCase
	{
		private readonly ITeacherRepository _teacherRepository;

		public GetTeacherUseCase(ITeacherRepository teacherRepository)
		{
			_teacherRepository = teacherRepository;
		}

		public async Task<PaginateResponseDTO<TeacherDTO>> GetTeachers(QueryRequestDTO filters)
		{
			var teachers = await _teacherRepository.GetAllTeacher(filters);
			var totalRecords = await _teacherRepository.TeachersTotalRecordsAsync(filters);
			var pageCount = (int)Math.Ceiling(totalRecords / (decimal)filters.RowsPage);

			var result = new PaginateResponseDTO<TeacherDTO>
			{
				Page = filters.Page,
				RowsPage = filters.RowsPage,
				TotalRecords = totalRecords,
				PageCount = pageCount,
				List = teachers.Select(x =>
				new TeacherDTO
				{
					Id = x.Id,
					Name = x.Name,
					LastName = x.LastName,
					Email = x.Email,
					PhoneNumber = x.PhoneNumber,
					CreatedOn = x.CreatedOn,
				}),
			};

			return result;
		}
	}
}
