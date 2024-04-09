namespace Finanzauto.Domain.Dtos
{
	public class QueryRequestDTO
	{
		public string ColumnOrder { get; set; } = string.Empty;
		public bool Desc { get; set; }
		public int Page { get; set; }
		public string Search { get; set; } = string.Empty;
		public int RowsPage { get; set; }
	}
}
