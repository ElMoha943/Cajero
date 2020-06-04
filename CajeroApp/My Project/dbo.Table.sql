CREATE TABLE [dbo].[Productos]
(
	[producto_id] INT NOT NULL PRIMARY KEY, 
    [producto_nombre] NVARCHAR(50) NULL, 
    [producto_stock] SMALLINT NULL, 
    [producto_precio] SMALLMONEY NULL
)
