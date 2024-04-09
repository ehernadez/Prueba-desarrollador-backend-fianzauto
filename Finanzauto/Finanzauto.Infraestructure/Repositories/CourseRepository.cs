using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Interfaces;
using Finanzauto.Infraestructure.DataContext;
using Finanzauto.Infraestructure.SqlStatements;
using System.Data.SqlClient;

namespace Finanzauto.Infraestructure.Repositories
{
	internal class CourseRepository : BaseRepository, ICourseRepository
	{
		readonly IFinanzautoContext Context;

		public CourseRepository(IFinanzautoContext context)
		{
			Context = context;
		}

		public async Task<int> CoursesTotalRecordsAsync(QueryRequestDTO filters)
		{
			var sqlStatement = FormatOrderSqlQuery(SqlStatement.Course_TotalRecords, filters.Desc, filters.ColumnOrder);
			SqlParameter[] parameters = GetFilterParameters(filters);

			return await Context.GetSingleValueAsync<int>(sqlStatement, parameters);
		}

		public async Task CreateCourse(Course course)
		{
			var sqlStatement = SqlStatement.Course_Create;

			SqlParameter[] parameters = new SqlParameter[] {
				new("@Name", course.Name),
				new("@CreatedBy", course.CreatedBy),
				new("@CreatedOn", course.CreatedOn),
			};

			await Context.SentenciaTaskAsync(sqlStatement, parameters);
		}

		public async Task<IEnumerable<Course>> GetAllCourse(QueryRequestDTO filters)
		{
			var sqlStatement = FormatOrderSqlQuery(SqlStatement.Course_GetCourses, filters.Desc, filters.ColumnOrder);
			SqlParameter[] parameters = GetFilterParameters(filters);

			return await Context.GetAsync<Course>(sqlStatement, parameters);
		}

		public async Task UpdateCourse(Course course)
		{
			var sqlStatement = SqlStatement.Course_Update;

			SqlParameter[] parameters = new SqlParameter[] {
				new("@Id", course.Id),
				new("@Name", course.Name),
				new("@ModifiedBy", course.ModifiedBy),
				new("@ModifiedOn", course.ModifiedOn),
			};

			await Context.SentenciaTaskAsync(sqlStatement, parameters);
		}

		public async Task DeleteCourse(Course course)
		{
			var sqlStatement = SqlStatement.Course_Delete;

			SqlParameter[] parameters = new SqlParameter[] {
				new("@Id", course.Id),
				new("@ModifiedBy", course.ModifiedBy),
				new("@ModifiedOn", course.ModifiedOn),
			};

			await Context.SentenciaTaskAsync(sqlStatement, parameters);
		}
	}
}
