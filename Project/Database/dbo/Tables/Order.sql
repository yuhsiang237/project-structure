CREATE TABLE [dbo].[Order] (
    [OrderNumber] NVARCHAR (50) NOT NULL,
    [OrderType] INT NOT NULL,
    [CreatedDate] DATETIME NOT NULL,
    [Remark] NVARCHAR(100) NULL, 
    [IsValid]     BIT           NOT NULL,
    [CreatedOn]   DATETIME      NOT NULL,
    [ChangedOn]   DATETIME      NOT NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED (
    [OrderNumber] ASC,
    [OrderType] ASC)
);

GO

EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Order Number',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Order',
    @level2type = N'COLUMN',
    @level2name = N'OrderNumber'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Create Order Date',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Order',
    @level2type = N'COLUMN',
    @level2name = N'CreatedDate'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Order Type',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Order',
    @level2type = N'COLUMN',
    @level2name = N'OrderType'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Order Remark',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Order',
    @level2type = N'COLUMN',
    @level2name = N'Remark'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'IsValid',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Order',
    @level2type = N'COLUMN',
    @level2name = N'IsValid'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'System Record Change Date',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Order',
    @level2type = N'COLUMN',
    @level2name = N'ChangedOn'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'System Record Create Date ',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Order',
    @level2type = N'COLUMN',
    @level2name = N'CreatedOn'