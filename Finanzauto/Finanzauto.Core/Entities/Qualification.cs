namespace Finanzauto.Domain.Entities
{
	public class Qualification : AuditableEntity
	{
        public int Id { get; set; }
        public string Score { get; set; } = string.Empty;
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
    }
}
