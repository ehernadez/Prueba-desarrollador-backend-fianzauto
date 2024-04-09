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
	public class DeleteCourseController : BaseController
	{
		private readonly IDeleteCourseUseCase _useCase;

		public DeleteCourseController(IDeleteCourseUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpDelete]
		public async Task<ResponseWithElements> DeleteCourse(DeleteDTO course)
		{
			return await ExecuteServiceAsync(async () => await _useCase.DeleteCourse(course, UserIdentity));
		}
	}
}
