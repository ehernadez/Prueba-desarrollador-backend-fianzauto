using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Interfaces;

namespace Finanzauto.Aplication.UseCases.Courses
{
	internal class GetCoursesUseCase : IGetCoursesUseCase
	{
		private readonly ICourseRepository _courseRepository;

		public GetCoursesUseCase(ICourseRepository courseRepository)
		{
			_courseRepository = courseRepository;
		}

		public async Task<PaginateResponseDTO<CourseDTO>> GetCourses(QueryRequestDTO filters)
		{
			var courses = await _courseRepository.GetAllCourse(filters);
			var totalRecords = await _courseRepository.CoursesTotalRecordsAsync(filters);
			var pageCount = (int)Math.Ceiling(totalRecords / (decimal)filters.RowsPage);

			var result = new PaginateResponseDTO<CourseDTO>
			{
				Page = filters.Page,
				RowsPage = filters.RowsPage,
				TotalRecords = totalRecords,
				PageCount = pageCount,
				List = courses.Select(x =>
				new CourseDTO
				{
					Id = x.Id,
					Name = x.Name,
					CreatedOn = x.CreatedOn,

				}),
			};

			return result;
		}
	}
}
