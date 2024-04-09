using Finanzauto.Domain.Entities;

namespace Finanzauto.Domain.Interfaces
{
	public interface IAuthRepository
	{
		Task<User> SignIn(User userCredential);
	}
}
