using Microsoft.AspNetCore.Mvc;
using OrderService.DataAccess;
using OrderService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderDetailsProvider _orderDetailsProvider;

        public OrdersController(IOrderDetailsProvider orderDetailsProvider)
        {
            _orderDetailsProvider = orderDetailsProvider;
        }

        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<OrderDetail> Get()
        {
            return _orderDetailsProvider.Get();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
