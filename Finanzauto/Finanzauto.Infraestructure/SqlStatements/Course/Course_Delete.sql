DECLARE @Remove BIT = 1;

UPDATE [Courses]
SET  
     [Remove] = @Remove
    ,[ModifiedBy] = @ModifiedBy
    ,[ModifiedOn] = @ModifiedOn
WHERE
    [Id] = @Id;
