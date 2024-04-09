SELECT U.Id, U.UserName, U.[Password], Rol.[Name] AS [Role]
FROM Users U
INNER JOIN Roles Rol ON U.RoleId = Rol.Id
Where [UserName] = @UserName 
And [Password] = @Password;