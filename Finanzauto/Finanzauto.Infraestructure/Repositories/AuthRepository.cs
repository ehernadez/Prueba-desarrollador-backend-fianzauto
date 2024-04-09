using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Interfaces;
using Finanzauto.Infraestructure.DataContext;
using Finanzauto.Infraestructure.SqlStatements;
using System.Data.SqlClient;

namespace Finanzauto.Infraestructure.Repositories
{
	internal class AuthRepository : IAuthRepository
	{
		readonly IFinanzautoContext Context;

		public AuthRepository(IFinanzautoContext context)
		{
			Context = context;
		}

		public async Task<User> SignIn(User userCredential)
		{
			var sqlStatement = SqlStatement.SignIn;

			SqlParameter[] parameters = new SqlParameter[] {
				new SqlParameter("@UserName", userCredential.UserName),
				new SqlParameter("@Password", userCredential.Password),
			};

			return await Context.GetSingleAsync<User>(sqlStatement, parameters);
		}
	}
}
