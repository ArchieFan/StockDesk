using Microsoft.AspNetCore.Mvc;
using WebApp.DataAccess;
using WebApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IStocksProvider _stocksProvider;

        public StocksController(IStocksProvider stocksProvider )
        {
            _stocksProvider = stocksProvider;
        }

        // GET: api/<StocksController>
        [HttpGet]
        public IEnumerable<Stock> Get()
        {
            return _stocksProvider.Get();
        }

        // GET api/<StocksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StocksController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StocksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StocksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
