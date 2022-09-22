using Microsoft.AspNetCore.Mvc;
using WebApp.DataAccess;
using WebApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfoliosController : ControllerBase
    {
        private readonly IPortfoliosProvider _portfoliosProvider;

        public PortfoliosController(IPortfoliosProvider portfoliosProvider)
        {
            _portfoliosProvider = portfoliosProvider;
        }

        // GET: api/<PortfoliosController>
        [HttpGet]
        public IEnumerable<Portfolio> Get()
        {
            var portfolios = _portfoliosProvider.Get();
            return portfolios;
        }

        // GET api/<PortfoliosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PortfoliosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PortfoliosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PortfoliosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
