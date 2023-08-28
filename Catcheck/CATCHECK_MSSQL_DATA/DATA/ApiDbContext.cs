using CATCHECK_MSSQL_DATA.Model;
using Microsoft.EntityFrameworkCore;

namespace CATCHECK_MSSQL_DATA.DATA
{
    public class ApiDbContext : DbContext
    {
        public DbSet<CATCHECK_MODEL> SqlCatcheck { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SqlCatcheckApidb;Trusted_Connection=True;");
        }
    }
}
