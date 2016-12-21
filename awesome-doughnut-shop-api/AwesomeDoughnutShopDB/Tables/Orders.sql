CREATE TABLE [dbo].[Orders]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserId] INT NOT NULL, 
    [OrderedDoughnutsId] INT NOT NULL, 
    [Date] DATETIME NOT NULL 
)
