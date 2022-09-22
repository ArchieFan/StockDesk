using Dapper;
using System.Data.SqlClient;
using WebApp.Models;

namespace WebApp.DataAccess
{
    public class PortfoliosProvider : IPortfoliosProvider
    {
        private readonly string _conStr;

        public PortfoliosProvider(string conStr)
        {
            _conStr = conStr;
        }

        public Portfolio[] Get()
        {
            using var conn = new SqlConnection(_conStr);
            return conn.Query<Portfolio>(@"SELECT Id, Name, Quantity, StockId FROM Portfolios").ToArray();
        }
    }
}
