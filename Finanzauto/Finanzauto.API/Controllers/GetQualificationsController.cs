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
	public class GetQualificationsController : BaseController
	{
		private readonly IGetQualificationsUseCase _useCase;

		public GetQualificationsController(IGetQualificationsUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpPost]
		public async Task<ResponseWithElements> GetQualifications(QueryRequestDTO filters)
		{
			return await ExecuteServiceAsync(async () => await _useCase.GetQualifications(filters));
		}
	}
}
