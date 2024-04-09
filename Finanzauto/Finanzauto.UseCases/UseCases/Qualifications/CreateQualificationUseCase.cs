using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Extensions;
using Finanzauto.Domain.Interfaces;

namespace Finanzauto.Aplication.UseCases.Qualifications
{
	internal class CreateQualificationUseCase : ICreateQualificationUseCase
	{
		private readonly IQualificationRepository _qualificationRepository;

		public CreateQualificationUseCase(IQualificationRepository qualificationRepository)
		{
			_qualificationRepository = qualificationRepository;
		}

		public async Task CreateQualification(CreateQualificationDTO qualification, int currentUserId)
		{
			qualification.Score.ValidateValue(nameof(qualification.Score));

			var createStudent = new Qualification
			{
				Score = qualification.Score,
				CourseId = qualification.CourseId,
				StudentId = qualification.StudentId,
				TeacherId = qualification.TeacherId,
				CreatedOn = DateTime.UtcNow,
				CreatedBy = currentUserId,
			};

			await _qualificationRepository.CreateQualification(createStudent);
		}
	}
}
