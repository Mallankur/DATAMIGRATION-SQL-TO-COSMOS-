using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MigrateCatCheckDataSQLTOCOSMOS.Controllers.SQL_TO_MongoController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CATCHEKDATAController : ControllerBase
    {
        // GET: api/<CatcheckController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CatcheckController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CatcheckController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CatcheckController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CatcheckController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
