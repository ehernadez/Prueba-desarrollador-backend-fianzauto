using Finanzauto.API.Responses;
using Finanzauto.Aplication.UseCases;
using Finanzauto.Domain.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Finanzauto.API.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class UpdateQualificationController : BaseController
	{
		private readonly IUpdateQualificationUseCase _useCase;

		public UpdateQualificationController(IUpdateQualificationUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpPut]
		public async Task<ResponseWithElements> UpdateQualification(UpdateQualificationDTO qualification)
		{
			return await ExecuteServiceAsync(async () => await _useCase.UpdateQualification(qualification, UserIdentity));
		}
	}
}
