using WebApp.Models;

namespace WebApp.DataAccess
{
    public interface IPortfoliosProvider
    {
        Portfolio[] Get(); 
    }
}
