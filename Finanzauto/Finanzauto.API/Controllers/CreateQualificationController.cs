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
	public class CreateQualificationController : BaseController
	{
		private readonly ICreateQualificationUseCase _useCase;

		public CreateQualificationController(ICreateQualificationUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpPost]
		public async Task<ResponseWithElements> CreateQualification(CreateQualificationDTO qualification)
		{
			return await ExecuteServiceAsync(async () => await _useCase.CreateQualification(qualification, UserIdentity));
		}
	}
}
