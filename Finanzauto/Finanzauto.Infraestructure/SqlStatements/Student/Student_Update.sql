UPDATE [Students]
SET  
     [Name] = @Name
    ,[LastName] = @LastName
    ,[Identification] = @Identification
    ,[Email] = @Email
    ,[PhoneNumber] = @PhoneNumber
    ,[ModifiedBy] = @ModifiedBy
    ,[ModifiedOn] = @ModifiedOn
WHERE
    [Id] = @Id;
