using CATCHECK_MSSQL_DATA.Infrastructure.CatcheckInterface;
using CATCHECK_MSSQL_DATA.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CATCHECK_MSSQL_DATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CATCHEKSQLController : ControllerBase
    {
        private readonly ICatCheck_Cal _cat;
        public CATCHEKSQLController(ICatCheck_Cal cat)
        {
            _cat = cat;
        }
        // GET: api/<CATCHEKSQLController>
        [HttpGet]
        public async Task<IEnumerable<CATCHECK_MODEL>> GetAllASYNCCATCHECKMSSQLDATA()
        {
           return  await _cat.GetAllCatcheckDataMSSQL();
        }

        // GET api/<CATCHEKSQLController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CATCHEKSQLController>
        [HttpPost]
        public async  Task  CatchecMssqldata([FromBody] List<CATCHECK_MODEL> value)
        {
            await _cat.CreateCatcheckData(value);   
        }

       

        // DELETE api/<CATCHEKSQLController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
