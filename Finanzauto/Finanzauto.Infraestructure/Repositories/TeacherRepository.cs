using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Interfaces;
using Finanzauto.Infraestructure.DataContext;
using Finanzauto.Infraestructure.SqlStatements;
using System.Data.SqlClient;

namespace Finanzauto.Infraestructure.Repositories
{
	internal class TeacherRepository : BaseRepository, ITeacherRepository
	{
		readonly IFinanzautoContext Context;

		public TeacherRepository(IFinanzautoContext context)
		{
			Context = context;
		}

		public async Task CreateTeacher(Teacher teacher)
		{
			var sqlStatement = SqlStatement.Teacher_Create;

			SqlParameter[] parameters = new SqlParameter[] {
				new("@Name", teacher.Name),
				new("@LastName", teacher.LastName),
				new("@Email", teacher.Email),
				new("@PhoneNumber", teacher.PhoneNumber),
				new("@CreatedBy", teacher.CreatedBy),
				new("@CreatedOn", teacher.CreatedOn),
			};

			await Context.SentenciaTaskAsync(sqlStatement, parameters);
		}

		public async Task DeleteTeacher(Teacher teacher)
		{
			var sqlStatement = SqlStatement.Teacher_Delete;

			SqlParameter[] parameters = new SqlParameter[] {
				new("@Id", teacher.Id),
				new("@ModifiedBy", teacher.ModifiedBy),
				new("@ModifiedOn", teacher.ModifiedOn),
			};

			await Context.SentenciaTaskAsync(sqlStatement, parameters);
		}

		public async Task<IEnumerable<Teacher>> GetAllTeacher(QueryRequestDTO filters)
		{
			var sqlStatement = FormatOrderSqlQuery(SqlStatement.Teacher_GetTeachers, filters.Desc, filters.ColumnOrder);
			SqlParameter[] parameters = GetFilterParameters(filters);

			return await Context.GetAsync<Teacher>(sqlStatement, parameters);
		}

		public async Task<int> TeachersTotalRecordsAsync(QueryRequestDTO filters)
		{
			var sqlStatement = FormatOrderSqlQuery(SqlStatement.Teacher_TotalRecords, filters.Desc, filters.ColumnOrder);
			SqlParameter[] parameters = GetFilterParameters(filters);

			return await Context.GetSingleValueAsync<int>(sqlStatement, parameters);
		}

		public async Task UpdateTeacher(Teacher teacher)
		{
			var sqlStatement = SqlStatement.Teacher_Update;

			SqlParameter[] parameters = new SqlParameter[] {
				new("@Id", teacher.Id),
				new("@Name", teacher.Name),
				new("@LastName", teacher.LastName),
				new("@Email", teacher.Email),
				new("@PhoneNumber", teacher.PhoneNumber),
				new("@ModifiedBy", teacher.ModifiedBy),
				new("@ModifiedOn", teacher.ModifiedOn),
			};

			await Context.SentenciaTaskAsync(sqlStatement, parameters);
		}
	}
}
