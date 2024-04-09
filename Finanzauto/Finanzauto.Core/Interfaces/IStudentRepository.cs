using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;

namespace Finanzauto.Domain.Interfaces
{
	public interface IStudentRepository
	{
		Task CreateStudent(Student Student);
		Task<IEnumerable<Student>> GetAllStudent(QueryRequestDTO filters);
		Task<int> StudentsTotalRecordsAsync(QueryRequestDTO filters);
		Task UpdateStudent(Student Student);
		Task DeleteStudent(Student Student);
	}
}
