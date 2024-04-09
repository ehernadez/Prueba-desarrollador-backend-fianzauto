namespace Finanzauto.Domain.Entities
{
	public class QualificationResult : Qualification
	{
        public string CourseName { get; set; } = string.Empty;
        public string Teacher { get; set; } = string.Empty;
		public string Student { get; set; } = string.Empty;
	}
}
