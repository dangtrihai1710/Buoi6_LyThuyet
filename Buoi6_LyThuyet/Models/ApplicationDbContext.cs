using Microsoft.EntityFrameworkCore;
namespace Buoi6_LyThuyet.Models
{
    public class ApplicationDbContext : DbContext
    {
       public
    ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
    base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}
