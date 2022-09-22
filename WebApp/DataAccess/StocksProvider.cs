using Dapper;
using System.Data.SqlClient;
using WebApp.Models;

namespace WebApp.DataAccess
{
    public class StocksProvider : IStocksProvider
    {
        private readonly string _conStr;

        public StocksProvider(string conStr)
        {
            _conStr = conStr;
        }

        public Stock[] Get()
        {
            using var conn = new SqlConnection(_conStr);
            return conn.Query<Stock>(@"SELECT * FROM Stocks").ToArray();
        }
    }
}
