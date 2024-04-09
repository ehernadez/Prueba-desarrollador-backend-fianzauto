using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzauto.Domain.Dtos
{
	public class UpdateQualificationDTO
	{
		public int Id { get; set; }
		public string Score { get; set; } = string.Empty;
		public int CourseId { get; set; }
		public int StudentId { get; set; }
		public int TeacherId { get; set; }
	}
}
