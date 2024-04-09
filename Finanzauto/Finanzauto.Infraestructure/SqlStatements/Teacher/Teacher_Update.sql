UPDATE [Teachers]
SET  
     [Name] = @Name
    ,[LastName] = @LastName
    ,[Email] = @Email
    ,[PhoneNumber] = @PhoneNumber
    ,[ModifiedBy] = @ModifiedBy
    ,[ModifiedOn] = @ModifiedOn
WHERE
    [Id] = @Id;
