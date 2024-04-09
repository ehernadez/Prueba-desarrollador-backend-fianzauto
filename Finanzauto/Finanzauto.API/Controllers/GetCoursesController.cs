using Finanzauto.API.Responses;
using Finanzauto.Aplication.UseCases;
using Finanzauto.Domain.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Finanzauto.API.Controllers
{
	[Authorize]
	[ApiController]
	[Route("api/[controller]")]
	public class GetCoursesController : BaseController
	{
		private readonly IGetCoursesUseCase _useCase;

		public GetCoursesController(IGetCoursesUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpPost]
		public async Task<ResponseWithElements> GetCourses(QueryRequestDTO filters)
		{
			return await ExecuteServiceAsync(async () => await _useCase.GetCourses(filters));
		}
	}
}
