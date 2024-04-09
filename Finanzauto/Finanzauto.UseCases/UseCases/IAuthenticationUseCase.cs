using Finanzauto.Domain.Dtos;

namespace Finanzauto.Aplication.UseCases
{
	public interface IAuthenticationUseCase
	{
		Task<AccessCredentialDTO> SignIn(UserCredentialDTO userCredential);
	}
}
