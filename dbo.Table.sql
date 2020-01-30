CREATE TABLE  [dbo].[Table] 
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [User_Name] NCHAR(20) NOT NULL, 
    [Full_Name] NCHAR(20) NULL, 
    [Password] NCHAR(20) NOT NULL, 
    [Accessibility] INT NOT NULL
)
