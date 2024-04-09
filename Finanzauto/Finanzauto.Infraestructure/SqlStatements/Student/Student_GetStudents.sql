DECLARE @NotRemove BIT = 0;

SELECT [Id]
      ,[Name]
      ,[LastName]
      ,[Identification]
      ,[Email]
      ,[PhoneNumber]
      ,[CreatedBy]
      ,[CreatedOn]
      ,[ModifiedBy]
      ,[ModifiedOn]
  FROM [Students] 
  WHERE ([Identification] LIKE '%' + @Search + '%' OR @Search IS NULL OR @Search = '')
  AND [Remove] = @NotRemove
  ORDER BY
	[{0}] {1}
    OFFSET 
	    ((@Page - 1) * @RowsPage) ROWS
    FETCH NEXT
	    @RowsPage ROWS ONLY;