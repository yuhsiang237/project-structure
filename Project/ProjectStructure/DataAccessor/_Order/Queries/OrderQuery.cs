using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Dapper;
using Microsoft.Extensions.Configuration;

using ProjectStructure.Enums;

namespace ProjectStructure.DataAccessor.Queries
{
    public class OrderQuery : IOrderQuery
    {
        private string _connectStr;

        /// <summary>
        /// Constructor
        /// </summary>
        public OrderQuery()
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json");
            var config = builder.Build();
            _connectStr = config["DBConnection"];
        }
        /// <inheritdoc/>
        public async Task<List<OrderQueryModel>> FindByOptionsAsync(
            string orderNumber,
            OrderType? orderType,
            DateTime? startDate,
            DateTime? endDate
            )
        {
            var sql = @"
                SELECT 
                    [OrderNumber],
                    [OrderType],
                    [CreatedDate],
                    [Remark]
                FROM 
                    [Order]";
            var conditions = new List<string>(){
                $"[IsValid] = @IsValid"
            };
            if (!string.IsNullOrEmpty(orderNumber))
                conditions.Add($"[OrderNumber] = @OrderNumber");
            if (orderType.HasValue)
                conditions.Add($"[OrderType] = @OrderType");
            if (startDate.HasValue)
                conditions.Add($"@StartDate <= [CreatedDate]");
            if (endDate.HasValue)
                conditions.Add($"[CreatedDate] < @EndDate");

            if (conditions.Any())
                sql = string.Concat(sql, Environment.NewLine, " WHERE ", string.Join(" AND ", conditions));

            using var conn = new SqlConnection(_connectStr);
            var data = conn.Query<OrderQueryModel>(sql, new
            {
                IsValid = true,
                OrderNumber = orderNumber,
                OrderType = orderType,
                StartDate = startDate,
                EndDate = endDate,
            });
            conn.Dispose();

            return data.ToList();
        }
    }
}
