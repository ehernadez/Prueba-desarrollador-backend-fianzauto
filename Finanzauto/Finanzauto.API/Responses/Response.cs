namespace Finanzauto.API.Responses
{
	public class Response
	{
		public bool Success { get; set; }
		public int StatusCode { get; set; }
		public string StatusText { get; set; } = string.Empty;
		public string Message { get; set; } = string.Empty;
	}
}
