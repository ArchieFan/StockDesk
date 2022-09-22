CREATE TABLE [dbo].[Portfolios]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [StockId] INT NOT NULL
)
