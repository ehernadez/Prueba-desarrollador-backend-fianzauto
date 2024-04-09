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
	public class DeleteStudentController : BaseController
	{
		private readonly IDeleteStudentUseCase _useCase;

		public DeleteStudentController(IDeleteStudentUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpDelete]
		public async Task<ResponseWithElements> DeleteStudent(DeleteDTO student)
		{
			return await ExecuteServiceAsync(async () => await _useCase.DeleteStudent(student, UserIdentity));
		}
	}
}
