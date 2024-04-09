DECLARE @Remove BIT = 1;

UPDATE [Students]
SET  
     [Remove] = @Remove
    ,[ModifiedBy] = @ModifiedBy
    ,[ModifiedOn] = @ModifiedOn
WHERE
    [Id] = @Id;
