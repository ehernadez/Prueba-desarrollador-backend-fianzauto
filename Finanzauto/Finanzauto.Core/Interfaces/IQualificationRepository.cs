using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;

namespace Finanzauto.Domain.Interfaces
{
	public interface IQualificationRepository
	{
		Task CreateQualification(Qualification qualification);
		Task<IEnumerable<QualificationResult>> GetAllQualification(QueryRequestDTO filters);
		Task<int> QualificationsTotalRecordsAsync(QueryRequestDTO filters);
		Task UpdateQualification(Qualification qualification);
		Task DeleteQualification(Qualification qualification);
	}
}
