﻿INSERT INTO [Students]
    (
      [Name]
     ,[LastName]
     ,[Identification]
     ,[Email]
     ,[PhoneNumber]
     ,[CreatedBy]
     ,[CreatedOn]
    )
VALUES
    (
      @Name
     ,@LastName
     ,@Identification
     ,@Email
     ,@PhoneNumber
     ,@CreatedBy
     ,@CreatedOn
	);