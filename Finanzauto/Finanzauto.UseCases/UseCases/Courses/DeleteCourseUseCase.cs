using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Interfaces;

namespace Finanzauto.Aplication.UseCases.Courses
{
	internal class DeleteCourseUseCase : IDeleteCourseUseCase
	{
		private readonly ICourseRepository _courseRepository;

		public DeleteCourseUseCase(ICourseRepository courseRepository)
		{
			_courseRepository = courseRepository;
		}

		public async Task DeleteCourse(DeleteDTO course, int currentUserId)
		{
			var deleteCourse = new Course
			{
				Id = course.Id,
				ModifiedBy = currentUserId,
				ModifiedOn = DateTime.UtcNow,
			};

			await _courseRepository.DeleteCourse(deleteCourse);
		}
	}
}
