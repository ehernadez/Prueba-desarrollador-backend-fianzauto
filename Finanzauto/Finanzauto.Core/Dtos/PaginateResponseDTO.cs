namespace Finanzauto.Domain.Dtos
{
	public class PaginateResponseDTO<T>
	{
		public int Page { get; set; }
		public int RowsPage { get; set; }
		public int PageCount { get; set; }
		public int TotalRecords { get; set; }
		public IEnumerable<T>? List { get; set; }
	}
}
