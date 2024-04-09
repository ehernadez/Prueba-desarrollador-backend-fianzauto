using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Extensions;
using Finanzauto.Domain.Interfaces;

namespace Finanzauto.Aplication.UseCases.Courses
{
	internal class CreateCourseUseCase : ICreateCourseUseCase
	{
		private readonly ICourseRepository _courseRepository;

		public CreateCourseUseCase(ICourseRepository courseRepository)
		{
			_courseRepository = courseRepository;
		}

		public async Task CreateCourse(CreateCourseDTO course, int currentUserId)
		{
			course.Name.ValidateValue(nameof(course.Name));

			var createCourse = new Course
			{
				Name = course.Name,
				CreatedOn = DateTime.UtcNow,
				CreatedBy = currentUserId,
			};

			await _courseRepository.CreateCourse(createCourse);
		}
	}
}
