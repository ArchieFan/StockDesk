using WebApp.Models;

namespace WebApp.DataAccess
{
    public interface IOrderDetailsProvider
    {
        OrderDetail[] Get(); 
    }
}
