DECLARE @NotRemove BIT = 0;

SELECT [Id]
      ,[Name]
      ,[LastName]
      ,[Email]
      ,[PhoneNumber]
      ,[CreatedBy]
      ,[CreatedOn]
      ,[ModifiedBy]
      ,[ModifiedOn]
  FROM [Teachers] 
  WHERE ([Name] LIKE '%' + @Search + '%' OR @Search IS NULL OR @Search = '')
  OR ([LastName] LIKE '%' + @Search + '%' OR @Search IS NULL OR @Search = '')
  OR ([Email] LIKE '%' + @Search + '%' OR @Search IS NULL OR @Search = '')
  AND [Remove] = @NotRemove
  ORDER BY
	[{0}] {1}
    OFFSET 
	    ((@Page - 1) * @RowsPage) ROWS
    FETCH NEXT
	    @RowsPage ROWS ONLY;