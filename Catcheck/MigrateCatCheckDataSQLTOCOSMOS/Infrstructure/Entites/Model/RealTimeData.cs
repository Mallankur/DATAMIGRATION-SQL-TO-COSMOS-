using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MigrateCatCheckDataSQLTOCOSMOS.Infrstructure.Entites.Model
{
    public class RealTimeData
    {

        [BsonId]
        public string Id { get; set; }

     
        public int RDID { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public int DOS { get; set; }
    }
}
