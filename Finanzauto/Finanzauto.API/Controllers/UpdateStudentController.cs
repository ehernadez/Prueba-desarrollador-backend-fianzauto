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
	public class UpdateStudentController : BaseController
	{
		private readonly IUpdateStudentsUseCase _useCase;

		public UpdateStudentController(IUpdateStudentsUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpPut]
		public async Task<ResponseWithElements> UpdateStudent(UpdateStudentDTO student)
		{
			return await ExecuteServiceAsync(async () => await _useCase.UpdateStudent(student, UserIdentity));
		}
	}
}
