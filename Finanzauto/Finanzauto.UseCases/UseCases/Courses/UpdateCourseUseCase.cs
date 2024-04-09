using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Interfaces;

namespace Finanzauto.Aplication.UseCases.Courses
{
	internal class UpdateCourseUseCase : IUpdateCourseUseCase
	{
		private readonly ICourseRepository _courseRepository;

		public UpdateCourseUseCase(ICourseRepository courseRepository)
		{
			_courseRepository = courseRepository;
		}

		public async Task UpdateCourse(UpdateCourseDTO course, int currentUserId)
		{
			var updateCourse = new Course
			{
				Id = course.Id,
				Name = course.Name,
				ModifiedBy = currentUserId,
				ModifiedOn = DateTime.UtcNow,
			};

			await _courseRepository.UpdateCourse(updateCourse);
		}
	}
}
