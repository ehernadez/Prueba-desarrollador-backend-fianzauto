DECLARE @NotRemove BIT = 0;

SELECT 
	COUNT(*)
  FROM [Qualifications] Q
  INNER JOIN Courses C ON Q.CourseId = C.Id  
  INNER JOIN Teachers T ON Q.TeacherId = T.Id  
  INNER JOIN Students S ON Q.StudentId = S.Id
  WHERE (C.[Name] LIKE '%' + @Search + '%' OR @Search IS NULL OR @Search = '')
  OR (CONCAT(T.[Name], ' ', COALESCE(T.[LastName], '')) LIKE '%' + @Search + '%' OR @Search IS NULL OR @Search = '')
  OR (CONCAT(S.[Name], ' ', COALESCE(S.[LastName], '')) LIKE '%' + @Search + '%' OR @Search IS NULL OR @Search = '')
  AND Q.[Remove] = @NotRemove