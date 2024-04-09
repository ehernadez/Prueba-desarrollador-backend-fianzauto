using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Interfaces;

namespace Finanzauto.Aplication.UseCases.Qualifications
{
	internal class GetQualificationsUseCase : IGetQualificationsUseCase
	{
		private readonly IQualificationRepository _qualificationRepository;

		public GetQualificationsUseCase(IQualificationRepository qualificationRepository)
		{
			_qualificationRepository = qualificationRepository;
		}

		public async Task<PaginateResponseDTO<QualificationDTO>> GetQualifications(QueryRequestDTO filters)
		{
			var qualifications = await _qualificationRepository.GetAllQualification(filters);
			var totalRecords = await _qualificationRepository.QualificationsTotalRecordsAsync(filters);
			var pageCount = (int)Math.Ceiling(totalRecords / (decimal)filters.RowsPage);

			var result = new PaginateResponseDTO<QualificationDTO>
			{
				Page = filters.Page,
				RowsPage = filters.RowsPage,
				TotalRecords = totalRecords,
				PageCount = pageCount,
				List = qualifications.Select(x =>
				new QualificationDTO
				{
					Id = x.Id,
					Score = x.Score,
					CourseId = x.CourseId,
					CourseName = x.CourseName,
					Student = x.Student,
					StudentId = x.StudentId,
					Teacher = x.Teacher,
					TeacherId = x.TeacherId,
					CreatedOn = x.CreatedOn,
				}),
			};

			return result;
		}
	}
}
