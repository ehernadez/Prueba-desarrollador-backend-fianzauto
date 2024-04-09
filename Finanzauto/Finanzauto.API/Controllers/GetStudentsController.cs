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
	public class GetStudentsController : BaseController
	{
		private readonly IGetStudentsUseCase _useCase;

		public GetStudentsController(IGetStudentsUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpPost]
		public async Task<ResponseWithElements> GetStudents(QueryRequestDTO filters)
		{
			return await ExecuteServiceAsync(async () => await _useCase.GetStudents(filters));
		}
	}
}
