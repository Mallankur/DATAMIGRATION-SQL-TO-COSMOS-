using CATCHECK_MSSQL_DATA.Model;

namespace CATCHECK_MSSQL_DATA.Infrastructure.CatcheckInterface
{
    public interface ICatCheck_Cal
    {
        Task CreateCatcheckData(List<CATCHECK_MODEL> models);

        Task<List<CATCHECK_MODEL>> GetAllCatcheckDataMSSQL();

        Task<CATCHECK_MODEL> GetCatCheckDataby_ID(int _id);

        Task<int?>DeleteCatCheckbyId(int ? _id);   

    }
}
