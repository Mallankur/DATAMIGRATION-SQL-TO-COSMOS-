using MigrateCatCheckDataSQLTOCOSMOS.Infrstructure.Entites.Model;

namespace MigrateCatCheckDataSQLTOCOSMOS.Infrstructure.Entites.MongoInterfaces
{
    public interface IMigrationServeises
    {
        Task<List<RealTimeData>> GetRealTimeDataAsync();

        Task<List<RealTimeData>> GetALLDataFromCosmos();

        Task<RealTimeData>GetBY_IDAsync(string _ID);




    }
}
