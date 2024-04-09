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
	public class DeleteQualificationController : BaseController
	{
		private readonly IDeleteQualificationUseCase _useCase;

		public DeleteQualificationController(IDeleteQualificationUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpDelete]
		public async Task<ResponseWithElements> DeleteQualification(DeleteDTO qualification)
		{
			return await ExecuteServiceAsync(async () => await _useCase.DeleteQualification(qualification, UserIdentity));
		}
	}
}
