using Finanzauto.Domain.Dtos;
using System.Data.SqlClient;

namespace Finanzauto.Infraestructure.Repositories
{
	public class BaseRepository
	{
		public static SqlParameter[] GetFilterParameters(QueryRequestDTO filters)
		{
			SqlParameter[] parameters = new SqlParameter[] {
				new("@Page", filters.Page),
				new("@RowsPage", filters.RowsPage),
				new("@Search", filters.Search)
			};

			return parameters;
		}

		public static string FormatOrderSqlQuery(string query, bool desc, string columnOrder)
		{
			string isDesc = desc ? "DESC" : "ASC";
			string sqlStatement = string.Format(query, columnOrder, isDesc);

			return sqlStatement;
		}
	}
}
