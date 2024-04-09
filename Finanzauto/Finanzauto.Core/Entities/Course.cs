namespace Finanzauto.Domain.Entities
{
	public class Course : AuditableEntity
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
	}
}
