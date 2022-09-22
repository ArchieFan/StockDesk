using Dapper;
using System.Data.SqlClient;
using WebApp.Models;

namespace WebApp.DataAccess
{
    public class OrderDetailsProvider : IOrderDetailsProvider
    {
        private readonly string _conStr;

        public OrderDetailsProvider(string conStr)
        {
            _conStr = conStr;
        }

        public OrderDetail[] Get()
        {
            using var conn = new SqlConnection(_conStr);
            return conn.Query<OrderDetail>(@"SELECT C.FirstName + ' ' + C.LastName AS [User], S.Name, OD.Quantity 
                FROM   dbo.Orders AS O INNER JOIN
                dbo.OrderDetails AS OD ON O.Id = OD.OrderId INNER JOIN
                dbo.Stocks AS S ON OD.StockId = S.Symbol INNER JOIN
                dbo.Clients AS C ON O.ClientId = C.Id").ToArray();
        }
    }
}
