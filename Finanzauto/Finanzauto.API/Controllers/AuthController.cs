using Finanzauto.API.Responses;
using Finanzauto.Aplication.UseCases;
using Finanzauto.Domain.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Finanzauto.API.Controllers
{
	[AllowAnonymous]
	[ApiController]
	[Route("api/[controller]")]
	public class AuthController : BaseController
	{
		private readonly IAuthenticationUseCase _useCase;

		public AuthController(IAuthenticationUseCase useCase)
		{
			_useCase = useCase;
		}

		[HttpPost]
		public async Task<ResponseWithElements> SignIn(UserCredentialDTO userCredential)
		{
			return await ExecuteServiceAsync(async () => await _useCase.SignIn(userCredential));
		}
	}
}
