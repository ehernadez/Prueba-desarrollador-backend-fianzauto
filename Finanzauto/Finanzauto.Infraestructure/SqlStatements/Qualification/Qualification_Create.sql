INSERT INTO [Qualifications]
    (
      [Score]
     ,[CourseId]
     ,[StudentId]
     ,[TeacherId]
     ,[CreatedBy]
     ,[CreatedOn]
    )
VALUES
    (
      @Score
     ,@CourseId
     ,@StudentId
     ,@TeacherId
     ,@CreatedBy
     ,@CreatedOn
	);