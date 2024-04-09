DECLARE @Remove BIT = 1;

UPDATE [Teachers]
SET  
     [Remove] = @Remove
    ,[ModifiedBy] = @ModifiedBy
    ,[ModifiedOn] = @ModifiedOn
WHERE
    [Id] = @Id;
