namespace Finanzauto.Domain.Extensions
{
	public static class ObjectExtension
	{
		public static void ValidateValue(this object @object, string fieldName)
		{
			if (@object == null || (@object is string str && string.IsNullOrWhiteSpace(str)))
			{
				throw new ApplicationException($"the '{fieldName}' field is required");
			}
		}
	}
}
