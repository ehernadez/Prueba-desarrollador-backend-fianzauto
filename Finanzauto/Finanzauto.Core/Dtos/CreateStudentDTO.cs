namespace Finanzauto.Domain.Dtos
{
	public class CreateStudentDTO
	{
		public string Name { get; set; } = string.Empty;
		public int Identification { get; set; }
		public string LastName { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string PhoneNumber { get; set; } = string.Empty;
	}
}
