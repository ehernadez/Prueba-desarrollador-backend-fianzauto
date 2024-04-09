using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;

namespace Finanzauto.Domain.Interfaces
{
	public interface ICourseRepository
	{
		Task CreateCourse(Course course);
		Task<IEnumerable<Course>> GetAllCourse(QueryRequestDTO filters);
		Task<int> CoursesTotalRecordsAsync(QueryRequestDTO filters);
		Task UpdateCourse(Course course);
		Task DeleteCourse(Course course);
	}
}
