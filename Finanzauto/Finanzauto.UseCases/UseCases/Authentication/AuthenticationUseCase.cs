using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Finanzauto.Aplication.UseCases.Authentication
{
	internal class AuthenticationUseCase : IAuthenticationUseCase
	{
		readonly IAuthRepository _authRepository;
		readonly IConfiguration _configuration;

		public AuthenticationUseCase(IAuthRepository authRepository, IConfiguration configuration)
		{
			_authRepository = authRepository;
			_configuration = configuration;
		}

		public async Task<AccessCredentialDTO> SignIn(UserCredentialDTO userCredential)
		{
			var user = new User
			{
				UserName = userCredential.UserName,
				Password = userCredential.Password,
			};

			var userSignInResult = await _authRepository.SignIn(user) ?? throw new ApplicationException("Login Failed");

			string userProfle = userSignInResult.Role;
			var expireToken = _configuration.GetValue<string>("JwtSettings:ExpireMinutes");
			double tokenExpireMinutes = double.Parse(expireToken);
			string accessToken = GenerateJwtToken(userSignInResult.Id, userProfle, tokenExpireMinutes);

			return new AccessCredentialDTO
			{
				AccessToken = accessToken,
				ExpiresIn = tokenExpireMinutes,
				Role = userProfle
			};
		}

		private string GenerateJwtToken(int userId, string userProfile, double tokenExpireMinutes)
		{
			var tokenHandler = new JwtSecurityTokenHandler();
			var jwtSecretKey = _configuration.GetValue<string>("JwtSettings:SecretKey");
			var keyBytes = Encoding.ASCII.GetBytes(jwtSecretKey);
			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(new[]
				{
					new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
					new Claim(ClaimTypes.Role, userProfile),
					new Claim(ClaimTypes.Authentication, "Bearer"),
				}),
				Expires = DateTime.UtcNow.AddMinutes(tokenExpireMinutes),
				Audience = _configuration.GetValue<string>("JwtSettings:Audience"),
				Issuer = _configuration.GetValue<string>("JwtSettings:Issuer"),
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256)
			};
			var token = tokenHandler.CreateToken(tokenDescriptor);

			return tokenHandler.WriteToken(token);
		}
	}
}
