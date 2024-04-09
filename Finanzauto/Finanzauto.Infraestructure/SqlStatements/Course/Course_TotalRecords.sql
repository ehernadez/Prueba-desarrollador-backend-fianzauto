DECLARE @NotRemove BIT = 0;

SELECT 
	COUNT(*)
  FROM [Courses] 
  WHERE ([Name] LIKE '%' + @Search + '%' OR @Search IS NULL OR @Search = '') 
  AND [Remove] = @NotRemove;