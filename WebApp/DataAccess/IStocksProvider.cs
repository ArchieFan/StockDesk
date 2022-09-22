using WebApp.Models;

namespace WebApp.DataAccess
{
    public interface IStocksProvider
    {
        Stock[] Get(); 
    }
}
