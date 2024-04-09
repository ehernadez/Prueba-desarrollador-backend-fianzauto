using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Interfaces;

namespace Finanzauto.Aplication.UseCases.Qualifications
{
	internal class DeleteQualificationUseCase : IDeleteQualificationUseCase
	{
		private readonly IQualificationRepository _qualificationRepository;

		public DeleteQualificationUseCase(IQualificationRepository qualificationRepository)
		{
			_qualificationRepository = qualificationRepository;
		}

		public async Task DeleteQualification(DeleteDTO qualification, int currentUserId)
		{
			var deleteQualification = new Qualification
			{
				Id = qualification.Id,
				ModifiedBy = currentUserId,
				ModifiedOn = DateTime.UtcNow,
			};

			await _qualificationRepository.DeleteQualification(deleteQualification);
		}
	}
}
