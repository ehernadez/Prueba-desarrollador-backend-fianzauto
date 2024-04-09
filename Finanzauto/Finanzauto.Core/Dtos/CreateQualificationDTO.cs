namespace Finanzauto.Domain.Dtos
{
	public class CreateQualificationDTO
	{
		public string Score { get; set; } = string.Empty;
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
    }
}
