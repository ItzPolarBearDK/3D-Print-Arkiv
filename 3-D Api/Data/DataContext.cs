using _3_D_Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace _3_D_Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Bruger> Brugere { get; set; }
    }
}
