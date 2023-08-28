using Microsoft.AspNetCore.Mvc;
using MigrateCatCheckDataSQLTOCOSMOS.Infrstructure.Entites.Model;
using MigrateCatCheckDataSQLTOCOSMOS.Infrstructure.Entites.MongoInterfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MigrateCatCheckDataSQLTOCOSMOS.Controllers.SQL_TO_MongoController
{
    [Route("api/[controller]")]
    [ApiController]
    public class COSMOSController : ControllerBase
    {
        private readonly IMigrationServeises _migrationServeises;
        public COSMOSController(IMigrationServeises migrationServeises)
        {
            _migrationServeises = migrationServeises;
        }
        // GET: api/<SQL_TO_Mongo_Controller>
        [HttpGet]
        public async Task<IEnumerable<RealTimeData>> GetAsync()
        {
           var res = await _migrationServeises.GetRealTimeDataAsync();    
            

            return res; 
        }
        [HttpGet("COSMOS_DATA")]
        public async Task<IEnumerable<RealTimeData>> GetOtherDataAsync()
        {
            var otherData = await _migrationServeises.GetALLDataFromCosmos();
            return otherData;
        }


        // GET api/<SQL_TO_Mongo_Controller>/5
        [HttpGet("{id}")]
        public async Task<RealTimeData> Get(string id)
        {
           return  await _migrationServeises.GetBY_IDAsync(id);    
        }

        // POST api/<SQL_TO_Mongo_Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        
    }
}
