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
	public class UpdateTeacherController : BaseController
	{
		private readonly IUpdateTeacherUseCase _useCase;

		public UpdateTeacherController(IUpdateTeacherUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpPut]
		public async Task<ResponseWithElements> GetCourses(UpdateTeacherDTO teacher)
		{
			return await ExecuteServiceAsync(async () => await _useCase.UpdateTeacher(teacher, UserIdentity));
		}
	}
}
