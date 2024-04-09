INSERT INTO [Teachers]
    (
      [Name]
     ,[LastName]
     ,[Email]
     ,[PhoneNumber]
     ,[CreatedBy]
     ,[CreatedOn]
    )
VALUES
    (
      @Name
     ,@LastName
     ,@Email
     ,@PhoneNumber
     ,@CreatedBy
     ,@CreatedOn
	);