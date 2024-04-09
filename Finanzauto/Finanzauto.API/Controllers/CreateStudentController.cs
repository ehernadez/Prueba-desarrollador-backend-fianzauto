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
	public class CreateStudentController : BaseController
	{
		private readonly ICreateStudentUseCase _useCase;

		public CreateStudentController(ICreateStudentUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpPost]
		public async Task<ResponseWithElements> CreateCourse(CreateStudentDTO student)
		{
			return await ExecuteServiceAsync(async () => await _useCase.CreateStudent(student, UserIdentity));
		}
	}
}
