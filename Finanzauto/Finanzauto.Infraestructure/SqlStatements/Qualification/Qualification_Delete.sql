DECLARE @Remove BIT = 1;

UPDATE [Qualifications]
SET  
     [Remove] = @Remove
    ,[ModifiedBy] = @ModifiedBy
    ,[ModifiedOn] = @ModifiedOn
WHERE
    [Id] = @Id;
