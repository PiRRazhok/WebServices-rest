CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] TEXT NULL, 
    [Role] TEXT NULL DEFAULT 'client', 
    [Email] TEXT NULL, 
    [Password] TEXT NULL
)
