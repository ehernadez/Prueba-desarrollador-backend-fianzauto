using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Interfaces;
using Finanzauto.Infraestructure.DataContext;
using Finanzauto.Infraestructure.SqlStatements;
using System.Data.SqlClient;

namespace Finanzauto.Infraestructure.Repositories
{
	internal class StudentRepository : BaseRepository, IStudentRepository
	{
		readonly IFinanzautoContext Context;

		public StudentRepository(IFinanzautoContext context)
		{
			Context = context;
		}

		public async Task CreateStudent(Student student)
		{
			var sqlStatement = SqlStatement.Student_Create;

			SqlParameter[] parameters = new SqlParameter[] {
				new("@Name", student.Name),
				new("@LastName", student.LastName),
				new("@Identification", student.Identification),
				new("@Email", student.Email),
				new("@PhoneNumber", student.PhoneNumber),
				new("@CreatedBy", student.CreatedBy),
				new("@CreatedOn", student.CreatedOn),
			};

			await Context.SentenciaTaskAsync(sqlStatement, parameters);
		}

		public async Task DeleteStudent(Student student)
		{
			var sqlStatement = SqlStatement.Student_Delete;

			SqlParameter[] parameters = new SqlParameter[] {
				new("@Id", student.Id),
				new("@ModifiedBy", student.ModifiedBy),
				new("@ModifiedOn", student.ModifiedOn),
			};

			await Context.SentenciaTaskAsync(sqlStatement, parameters);
		}

		public async Task<IEnumerable<Student>> GetAllStudent(QueryRequestDTO filters)
		{
			var sqlStatement = FormatOrderSqlQuery(SqlStatement.Student_GetStudents, filters.Desc, filters.ColumnOrder);
			SqlParameter[] parameters = GetFilterParameters(filters);

			return await Context.GetAsync<Student>(sqlStatement, parameters);
		}

		public async Task<int> StudentsTotalRecordsAsync(QueryRequestDTO filters)
		{
			var sqlStatement = FormatOrderSqlQuery(SqlStatement.Student_TotalRecords, filters.Desc, filters.ColumnOrder);
			SqlParameter[] parameters = GetFilterParameters(filters);

			return await Context.GetSingleValueAsync<int>(sqlStatement, parameters);
		}

		public async Task UpdateStudent(Student student)
		{
			var sqlStatement = SqlStatement.Student_Update;

			SqlParameter[] parameters = new SqlParameter[] {
				new("@Id", student.Id),
				new("@Name", student.Name),
				new("@LastName", student.LastName),
				new("@Identification", student.Identification),
				new("@Email", student.Email),
				new("@PhoneNumber", student.PhoneNumber),
				new("@ModifiedBy", student.ModifiedBy),
				new("@ModifiedOn", student.ModifiedOn),
			};

			await Context.SentenciaTaskAsync(sqlStatement, parameters);
		}
	}
}
