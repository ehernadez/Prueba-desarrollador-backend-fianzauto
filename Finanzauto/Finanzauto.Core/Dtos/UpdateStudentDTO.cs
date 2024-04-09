namespace Finanzauto.Domain.Dtos
{
	public class UpdateStudentDTO
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public int Identification { get; set; }
		public string Email { get; set; } = string.Empty;
		public string PhoneNumber { get; set; } = string.Empty;
	}
}
