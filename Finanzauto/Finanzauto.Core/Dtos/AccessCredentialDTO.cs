namespace Finanzauto.Domain.Dtos
{
	public class AccessCredentialDTO
	{
		public string AccessToken { get; set; } = string.Empty;
		public double ExpiresIn { get; set; }
		public string Role { get; set; } = string.Empty;
	}
}
