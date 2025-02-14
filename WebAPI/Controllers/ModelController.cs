using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    /// <summary>
    /// Should interact with services from aplication layer
    /// Should use Dtos
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly IService _service;
        public ModelController(IService service)
        {
            _service = service;

        }
        // GET: api/<ModelController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ModelController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ModelController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ModelController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ModelController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        //GET: api/<ModelController>/GlobalError
        [HttpGet("/GlobalError")]
        public string GetGlobalEror()
        {
            throw new Exception("General");
        }
    }
}
