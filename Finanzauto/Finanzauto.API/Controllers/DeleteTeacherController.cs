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
	public class DeleteTeacherController : BaseController
	{
		private readonly IDeleteTeacherUseCase _useCase;

		public DeleteTeacherController(IDeleteTeacherUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpDelete]
		public async Task<ResponseWithElements> DeleteCourse(DeleteDTO course)
		{
			return await ExecuteServiceAsync(async () => await _useCase.DeleteTeacher(course, UserIdentity));
		}

	}
}
