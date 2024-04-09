UPDATE [Qualifications]
SET  
     [Score] = @Score
    ,[CourseId] = @CourseId
    ,[TeacherId] = @TeacherId
    ,[StudentId] = @StudentId
    ,[ModifiedBy] = @ModifiedBy
    ,[ModifiedOn] = @ModifiedOn
WHERE
    [Id] = @Id;
