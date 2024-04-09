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
	public class UpdateCourseController : BaseController
	{
		private readonly IUpdateCourseUseCase _useCase;

		public UpdateCourseController(IUpdateCourseUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpPut]
		public async Task<ResponseWithElements> UpdateCourse(UpdateCourseDTO course)
		{
			return await ExecuteServiceAsync(async () => await _useCase.UpdateCourse(course, UserIdentity));
		}
	}
}
