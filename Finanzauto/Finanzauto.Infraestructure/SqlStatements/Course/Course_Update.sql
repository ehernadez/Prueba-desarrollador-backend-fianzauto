UPDATE [Courses]
SET  
     [Name] = @Name
    ,[ModifiedBy] = @ModifiedBy
    ,[ModifiedOn] = @ModifiedOn
WHERE
    [Id] = @Id;
