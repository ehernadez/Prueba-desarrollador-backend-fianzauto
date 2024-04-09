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
	public class CreateCourseController : BaseController
	{
		private readonly ICreateCourseUseCase _useCase;

		public CreateCourseController(ICreateCourseUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpPost]
		public async Task<ResponseWithElements> CreateCourse(CreateCourseDTO course)
		{
			return await ExecuteServiceAsync(async () => await _useCase.CreateCourse(course, UserIdentity));
		}
	}
}
