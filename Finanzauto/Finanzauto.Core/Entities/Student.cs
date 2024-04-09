namespace Finanzauto.Domain.Entities
{
	public class Student : AuditableEntity
	{
		public int Id { get; set; }
		public int Identification { get; set; }
		public string Name { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string PhoneNumber { get; set; } = string.Empty;
	}
}
