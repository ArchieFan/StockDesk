CREATE TABLE [dbo].[OrderDetails]
(
	[OrderId] INT NOT NULL , 
    [StockId] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    PRIMARY KEY ([StockId], [OrderId])
)
