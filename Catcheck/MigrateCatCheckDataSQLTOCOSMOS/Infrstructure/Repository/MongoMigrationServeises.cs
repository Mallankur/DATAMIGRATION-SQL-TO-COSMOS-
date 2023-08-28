using Azure.Messaging.ServiceBus;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Amqp.Framing;
using Microsoft.Extensions.Options;
using MigrateCatCheckDataSQLTOCOSMOS.Data.MongoConnector;
using MigrateCatCheckDataSQLTOCOSMOS.Infrstructure.Entites.Model;
using MigrateCatCheckDataSQLTOCOSMOS.Infrstructure.Entites.MongoInterfaces;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System;
using Newtonsoft.Json;
using JsonConvert = Newtonsoft.Json.JsonConvert;

namespace MigrateCatCheckDataSQLTOCOSMOS.Infrstructure.Repository
{
    public class MongoMigrationServeises : IMigrationServeises
    {
        public IMongoCollection<RealTimeData> Pdt { get; }

        public MongoMigrationServeises(IOptions<MongoConnector> connect)
        {
            MongoClient client = new MongoClient(connect.Value.ConnectionString);
            IMongoDatabase database = client.GetDatabase(connect.Value.DatabaseName);
            Pdt = database.GetCollection<RealTimeData>(connect.Value.CollectionName);
           

        }

        public async  Task<List<RealTimeData>> GetRealTimeDataAsync()
        {
            string connectionString = "Endpoint=sb://mall123.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=BYSgibsTkLpA9w8cvvfPMSX4SUpIuFRhZ+ASbMEbhzg=";
            string queueName = "ank";
            await using var client = new ServiceBusClient(connectionString);
            var reciver = client.CreateReceiver(queueName);
            IReadOnlyList<ServiceBusReceivedMessage> receivedMessages = await reciver.ReceiveMessagesAsync(10);
            if (receivedMessages == null)
            {
                return null;
            }
            var insertedData = new List<RealTimeData>();

            foreach (ServiceBusReceivedMessage receivedMessage in receivedMessages)
            {
                string body = receivedMessage.Body.ToString();
                var messages = JsonConvert.DeserializeObject<List<RealTimeData>>(body);

                foreach (var messageCreated in messages)
                {
                    await Pdt.InsertOneAsync(messageCreated);
                    insertedData.Add(messageCreated);
                }

                await reciver.CompleteMessageAsync(receivedMessage);
            }

            var result = await Pdt.Find(_ => true).ToListAsync();
            return result;


        }

        public async  Task<List<RealTimeData>> GetALLDataFromCosmos()
        {
            var res = await Pdt.Find(x=>true).ToListAsync();  
            return res; 
        }

        public async Task<RealTimeData> GetBY_IDAsync(string _ID)
        {
            return await Pdt.Find(x =>x.Id==_ID).FirstOrDefaultAsync();
        }
    }
}
