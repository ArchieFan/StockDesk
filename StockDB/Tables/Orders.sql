CREATE TABLE [dbo].[Orders]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ClientId] INT NOT NULL, 
    [CreatedTime] DATETIME NOT NULL DEFAULT getdate()
)
