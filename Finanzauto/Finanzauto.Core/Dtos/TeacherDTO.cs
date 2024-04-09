namespace Finanzauto.Domain.Dtos
{
	public class TeacherDTO
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string PhoneNumber { get; set; } = string.Empty;
		public DateTime CreatedOn { get; set; }
	}
}
