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
	public class GetTeachersController : BaseController
	{
		private readonly IGetTeacherUseCase _useCase;

		public GetTeachersController(IGetTeacherUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpPost]
		public async Task<ResponseWithElements> GetCourses(QueryRequestDTO filters)
		{
			return await ExecuteServiceAsync(async () => await _useCase.GetTeachers(filters));
		}
	}
}
