using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Extensions;
using Finanzauto.Domain.Interfaces;

namespace Finanzauto.Aplication.UseCases.Qualifications
{
	internal class UpdateQualificationUseCase : IUpdateQualificationUseCase
	{
		private readonly IQualificationRepository _qualificationRepository;

		public UpdateQualificationUseCase(IQualificationRepository qualificationRepository)
		{
			_qualificationRepository = qualificationRepository;
		}

		public async Task UpdateQualification(UpdateQualificationDTO qualification, int currentUserId)
		{
			qualification.Score.ValidateValue(nameof(qualification.Score));

			var createQualification = new Qualification
			{
				Id = qualification.Id,
				Score = qualification.Score,
				CourseId = qualification.CourseId,
				StudentId = qualification.StudentId,
				TeacherId = qualification.TeacherId,
				ModifiedOn = DateTime.UtcNow,
				ModifiedBy = currentUserId,
			};

			await _qualificationRepository.UpdateQualification(createQualification);
		}
	}
}
