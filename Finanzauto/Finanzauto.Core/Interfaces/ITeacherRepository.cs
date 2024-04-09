using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;

namespace Finanzauto.Domain.Interfaces
{
	public interface ITeacherRepository
	{
		Task CreateTeacher(Teacher Teacher);
		Task<IEnumerable<Teacher>> GetAllTeacher(QueryRequestDTO filters);
		Task<int> TeachersTotalRecordsAsync(QueryRequestDTO filters);
		Task UpdateTeacher(Teacher Teacher);
		Task DeleteTeacher(Teacher Teacher);
	}
}
