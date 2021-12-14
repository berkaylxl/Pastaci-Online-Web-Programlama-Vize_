using Microsoft.EntityFrameworkCore;

namespace PastaciOnlineMVC.Models
{
    public class PastaciDbContext:DbContext
    {
        public PastaciDbContext(DbContextOptions<PastaciDbContext> dbContextOptions):base(dbContextOptions)
            { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
