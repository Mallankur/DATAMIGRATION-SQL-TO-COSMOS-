using Azure.Messaging.ServiceBus;
using CATCHECK_MSSQL_DATA.DATA;
using CATCHECK_MSSQL_DATA.Infrastructure.CatcheckInterface;
using CATCHECK_MSSQL_DATA.Model;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CATCHECK_MSSQL_DATA.Infrastructure.CatcheckServises
{
    public class CATCHECK_SERVISES : ICatCheck_Cal
    {
        private ApiDbContext _dbC;
        public CATCHECK_SERVISES()
        {
            _dbC = new ApiDbContext();
        }
        public async Task CreateCatcheckData(List<CATCHECK_MODEL> models)
        {
            await _dbC.SqlCatcheck.AddRangeAsync(models);
            await _dbC.SaveChangesAsync();
            string connectionString = "Endpoint=sb://mall123.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=BYSgibsTkLpA9w8cvvfPMSX4SUpIuFRhZ+ASbMEbhzg=";
            string queueName = "ank";
            await using var client = new ServiceBusClient(connectionString);
            var objectAsText = JsonConvert.SerializeObject(models);

            ServiceBusSender sender = client.CreateSender(queueName);

            ServiceBusMessage message = new ServiceBusMessage(objectAsText);

            await sender.SendMessageAsync(message);
        }

        public async Task<List<CATCHECK_MODEL>> GetAllCatcheckDataMSSQL()
        {
           var res =  await _dbC.SqlCatcheck.ToListAsync();

            return res; 
        }
    }
}
