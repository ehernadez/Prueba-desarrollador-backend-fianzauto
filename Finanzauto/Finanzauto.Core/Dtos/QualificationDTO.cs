namespace Finanzauto.Domain.Dtos
{
	public class QualificationDTO
	{
		public int Id { get; set; }
		public string Score { get; set; } = string.Empty;
		public int CourseId { get; set; }
		public int StudentId { get; set; }
		public int TeacherId { get; set; }
		public string CourseName { get; set; } = string.Empty;
		public string Teacher { get; set; } = string.Empty;
		public string Student { get; set; } = string.Empty;
		public DateTime CreatedOn { get; set; }
	}
}
