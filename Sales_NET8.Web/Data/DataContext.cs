namespace Sales_NET8.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Sales_NET8.Web.Data.Entities;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
            
        }

        public DbSet<Country> Countries { get; set; }
    }
}
