using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;

using Dapper;
using Microsoft.Extensions.Configuration;

namespace ProjectStructure.DataAccessor.Commands
{
    public class OrderCommand : IOrderCommand
    {
        private IDbConnection conn;
        private string _connectStr;

        /// <summary>
        /// Constructor
        /// </summary>
        public OrderCommand()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var config = builder.Build();
            _connectStr = config["DBConnection"];
        }

        ///<inheritdoc/>
        public async Task DeleteAsync(OrderCommandModel command)
        {
            var sql = @"
                UPDATE [Order]
                SET 
                    [IsValid] = @IsValid,
                    [ChangedOn] = @ChangedOn
                WHERE 
                    [OrderNumber] = @OrderNumber AND
                    [OrderType] = @OrderType
                ";

            conn = new SqlConnection(_connectStr);
            conn.Execute(sql, new
            {
                IsValid = false,
                OrderNumber = command.OrderNumber,
                OrderType = command.OrderType,
                Remark = command.Remark,
                ChangedOn = command.ChangedOn,
            });
            conn.Dispose();
        }

        ///<inheritdoc/>
        public async Task InsertAsync(OrderCommandModel command)
        {
            var sql = @"
                INSERT INTO [Order]
                (
                    [OrderNumber],
                    [OrderType],
                    [CreatedDate],
                    [Remark],
                    [CreatedOn],
                    [ChangedOn],
                    [IsValid]
                )
                VALUES
                (
                    @OrderNumber,
                    @OrderType,
                    @CreatedDate,
                    @Remark,
                    @CreatedOn,
                    @ChangedOn,
                    @IsValid
                )";

            conn = new SqlConnection(_connectStr);
            conn.Execute(sql, command);
            conn.Dispose();
        }

        ///<inheritdoc/>
        public async Task UpdateAsync(OrderCommandModel command)
        {
            var sql = @"
                UPDATE [Order]
                SET 
                    [Remark] = @Remark,
                    [ChangedOn] = @ChangedOn
                WHERE 
                    [OrderNumber] = @OrderNumber AND
                    [OrderType] = @OrderType;
                ";

            conn = new SqlConnection(_connectStr);
            conn.Execute(sql, command);
            conn.Dispose();
        }
    }
}