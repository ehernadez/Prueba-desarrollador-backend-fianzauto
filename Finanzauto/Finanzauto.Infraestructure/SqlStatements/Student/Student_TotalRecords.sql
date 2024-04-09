DECLARE @NotRemove BIT = 0;

SELECT 
	COUNT(*)
  FROM [Students] 
  WHERE ([Identification] LIKE '%' + @Search + '%' OR @Search IS NULL OR @Search = '')
  AND [Remove] = @NotRemove