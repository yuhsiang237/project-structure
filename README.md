# project-structure

### Order API SPEC
<table>
<tr>
<td>Method</td>
<td>API</td>
<td>Description</td>
</tr>
<tr>
<td>POST</td>
<td>GetOrderListAsync</td>
<td>get order list by options.</td>
</tr>
<tr>
<td>POST</td>
<td>GetOrderAsync</td>
<td>get order</td>
</tr>
<tr>
<td>POST</td>
<td>CreateOrderAsync</td>
<td>create new order</td>
</tr>
<tr>
<td>POST</td>
<td>UpdateOrderAsync</td>
<td>update a order</td>
</tr>
<tr>
<td>POST</td>
<td>DeleteOrderAsync</td>
<td>delete a order (soft delete)</td>
</tr>
</table>

### Order Table
```sql
CREATE TABLE [dbo].[Order] (
    [OrderNumber] NVARCHAR (50) NOT NULL,
    [OrderType] INT NOT NULL,
    [CreatedDate] DATETIME NOT NULL,
    [Remark] NVARCHAR(100) NULL, 
    [IsValid] BIT NOT NULL,
    [CreatedOn] DATETIME NOT NULL,
    [ChangedOn] DATETIME NOT NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED (
    [OrderNumber] ASC,
    [OrderType] ASC)
);
```

### System Structure
<img style="width:500px" src="https://github.com/yuhsiang237/project-structure/blob/master/Assets/1.system_structure.PNG?raw=true"/>


### ENV Of Developer 
- ASP.NET Core 3.1
- SQL Server 2019
- Visual Studio 2022
