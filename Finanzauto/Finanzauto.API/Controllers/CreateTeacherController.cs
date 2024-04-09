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
	public class CreateTeacherController : BaseController
	{
		private readonly ICreateTeacherUseCase _useCase;

		public CreateTeacherController(ICreateTeacherUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpPost]
		public async Task<ResponseWithElements> CreateCourse(CreateTeacherDTO teacher)
		{
			return await ExecuteServiceAsync(async () => await _useCase.CreateTeacher(teacher, UserIdentity));
		}
	}
}
