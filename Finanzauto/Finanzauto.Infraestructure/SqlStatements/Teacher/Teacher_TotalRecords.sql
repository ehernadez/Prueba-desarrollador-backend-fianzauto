DECLARE @NotRemove BIT = 0;

SELECT 
	COUNT(*)
  FROM [Teachers] 
  WHERE ([Name] LIKE '%' + @Search + '%' OR @Search IS NULL OR @Search = '')
  AND ([LastName] LIKE '%' + @Search + '%' OR @Search IS NULL OR @Search = '')
  AND ([Email] LIKE '%' + @Search + '%' OR @Search IS NULL OR @Search = '')
  AND [Remove] = @NotRemove;