using jQueryDatatablesMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace jQueryDatatablesMVC.Repository
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<PersonalInfo> PersonalInfo { get; set; }
    }
}
