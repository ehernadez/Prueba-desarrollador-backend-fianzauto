using Finanzauto.Domain.Dtos;
using Finanzauto.Domain.Entities;
using Finanzauto.Domain.Interfaces;
using Finanzauto.Infraestructure.DataContext;
using Finanzauto.Infraestructure.SqlStatements;
using System.Data.SqlClient;

namespace Finanzauto.Infraestructure.Repositories
{
	internal class QualificationRepository : BaseRepository, IQualificationRepository
	{
		readonly IFinanzautoContext Context;

		public QualificationRepository(IFinanzautoContext context)
		{
			Context = context;
		}

		public async Task CreateQualification(Qualification qualification)
		{
			var sqlStatement = SqlStatement.Qualification_Create;

			SqlParameter[] parameters = new SqlParameter[] {
				new("@Score", qualification.Score),
				new("@CourseId", qualification.CourseId),
				new("@TeacherId", qualification.TeacherId),
				new("@StudentId", qualification.StudentId),
				new("@CreatedBy", qualification.CreatedBy),
				new("@CreatedOn", qualification.CreatedOn),
			};

			await Context.SentenciaTaskAsync(sqlStatement, parameters);
		}

		public async Task DeleteQualification(Qualification qualification)
		{
			var sqlStatement = SqlStatement.Qualification_Delete;

			SqlParameter[] parameters = new SqlParameter[] {
				new("@Id", qualification.Id),
				new("@ModifiedBy", qualification.ModifiedBy),
				new("@ModifiedOn", qualification.ModifiedOn),
			};

			await Context.SentenciaTaskAsync(sqlStatement, parameters);
		}

		public async Task<IEnumerable<QualificationResult>> GetAllQualification(QueryRequestDTO filters)
		{
			var sqlStatement = FormatOrderSqlQuery(SqlStatement.Qualification_GetQualifications, filters.Desc, filters.ColumnOrder);
			SqlParameter[] parameters = GetFilterParameters(filters);

			return await Context.GetAsync<QualificationResult>(sqlStatement, parameters);
		}

		public async Task<int> QualificationsTotalRecordsAsync(QueryRequestDTO filters)
		{
			var sqlStatement = FormatOrderSqlQuery(SqlStatement.Qualification_TotalRecords, filters.Desc, filters.ColumnOrder);
			SqlParameter[] parameters = GetFilterParameters(filters);

			return await Context.GetSingleValueAsync<int>(sqlStatement, parameters);
		}

		public async Task UpdateQualification(Qualification qualification)
		{
			var sqlStatement = SqlStatement.Qualification_Update;

			SqlParameter[] parameters = new SqlParameter[] {
				new("@Id", qualification.Id),
				new("@Score", qualification.Score),
				new("@CourseId", qualification.CourseId),
				new("@TeacherId", qualification.TeacherId),
				new("@StudentId", qualification.StudentId),
				new("@ModifiedBy", qualification.ModifiedBy),
				new("@ModifiedOn", qualification.ModifiedOn),
			};

			await Context.SentenciaTaskAsync(sqlStatement, parameters);
		}
	}
}
