using OrderService.Models;

namespace OrderService.DataAccess
{
    public interface IOrderDetailsProvider
    {
        OrderDetail[] Get(); 
    }
}
