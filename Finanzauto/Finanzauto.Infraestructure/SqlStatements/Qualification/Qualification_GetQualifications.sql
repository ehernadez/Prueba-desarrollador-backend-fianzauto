DECLARE @NotRemove BIT = 0;

SELECT Q.[Id]
      ,Q.[Score]
      ,C.[Name] AS [CourseName]
	  ,CONCAT(T.[Name], ' ', COALESCE(T.[LastName], '')) AS [Teacher]
	  ,CONCAT(S.[Name], ' ', COALESCE(S.[LastName], '')) AS [Student]
      ,Q.[CourseId]
      ,Q.[TeacherId]
      ,Q.[StudentId]
      ,Q.[CreatedBy]
      ,Q.[CreatedOn]
      ,Q.[ModifiedBy]
      ,Q.[ModifiedOn]
  FROM [Qualifications] Q
  INNER JOIN Courses C ON Q.CourseId = C.Id  
  INNER JOIN Teachers T ON Q.TeacherId = T.Id  
  INNER JOIN Students S ON Q.StudentId = S.Id
  WHERE (C.[Name] LIKE '%' + @Search + '%' OR @Search IS NULL OR @Search = '')
  OR (CONCAT(T.[Name], ' ', COALESCE(T.[LastName], '')) LIKE '%' + @Search + '%' OR @Search IS NULL OR @Search = '')
  OR (CONCAT(S.[Name], ' ', COALESCE(S.[LastName], '')) LIKE '%' + @Search + '%' OR @Search IS NULL OR @Search = '')
  AND Q.[Remove] = @NotRemove
  ORDER BY
	[{0}] {1}
    OFFSET 
	    ((@Page - 1) * @RowsPage) ROWS
    FETCH NEXT
	    @RowsPage ROWS ONLY;