using System.Data.SqlClient;
using System.Reflection;

namespace Finanzauto.Infraestructure.DataContext
{
	internal class FinanzautoContext : IFinanzautoContext
	{
		private readonly SqlConnection _connection;

		public FinanzautoContext(SqlConnection connection)
		{
			_connection = connection;
		}

		public async Task<List<T>> GetAsync<T>(string query, params SqlParameter[] parameters) where T : new()
		{
			var result = new List<T>();
			using (var command = new SqlCommand(query, _connection))
			{
				command.Parameters.AddRange(parameters);
				using SqlDataReader reader = await command.ExecuteReaderAsync();
				while (await reader.ReadAsync())
				{
					var item = new T();
					for (int i = 0; i < reader.FieldCount; i++)
					{
						PropertyInfo propertyInfo = typeof(T).GetProperty(reader.GetName(i));
						if (propertyInfo != null && !reader.IsDBNull(i))
						{
							propertyInfo.SetValue(item, reader.GetValue(i));
						}
					}
					result.Add(item);
				}
			}
			return result;
		}

		public async Task<T> GetSingleAsync<T>(string query, params SqlParameter[] parameters) where T : new()
		{
			T result = default;
			using (var command = new SqlCommand(query, _connection))
			{
				command.Parameters.AddRange(parameters);
				using SqlDataReader reader = await command.ExecuteReaderAsync();
				if (reader.HasRows && await reader.ReadAsync())
				{
					result = new T();
					for (int i = 0; i < reader.FieldCount; i++)
					{
						PropertyInfo propertyInfo = typeof(T).GetProperty(reader.GetName(i));
						if (propertyInfo != null && !reader.IsDBNull(i))
						{
							propertyInfo.SetValue(result, reader.GetValue(i));
						}
					}
				}
			}
			return result;
		}

		public async Task<TValue> GetSingleValueAsync<TValue>(string query, params SqlParameter[] parameters)
		{
			TValue result = default;
			using (var command = new SqlCommand(query, _connection))
			{
				command.Parameters.AddRange(parameters);
				using SqlDataReader reader = await command.ExecuteReaderAsync();
				if (reader.HasRows && await reader.ReadAsync())
				{
					if (!reader.IsDBNull(0))
					{
						result = (TValue)reader.GetValue(0);
					}
				}
			}
			return result;
		}

		public async Task<int> InsertReturnIdAsync(string query, params SqlParameter[] parameters)
		{
			using var command = new SqlCommand(query, _connection);
			command.Parameters.AddRange(parameters);
			return Convert.ToInt32(await command.ExecuteScalarAsync());
		}

		public async Task<bool> SentenciaAsync(string query, params SqlParameter[] parameters)
		{
			using var command = new SqlCommand(query, _connection);
			command.Parameters.AddRange(parameters);
			await command.ExecuteNonQueryAsync();
			return true;
		}

		public async Task SentenciaTaskAsync(string query, params SqlParameter[] parameters)
		{
			using var command = new SqlCommand(query, _connection);
			command.Parameters.AddRange(parameters);
			await command.ExecuteNonQueryAsync();
		}
	}
}
