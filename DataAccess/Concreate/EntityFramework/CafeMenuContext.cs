using CafeMenuProject.Entities.Admin;
using CafeMenuProject.Models.Admin;
using Entities.Admin;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Concrete.EntityFramework
{   
    public class CafeMenuContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CafeMenu;Trusted_Connection=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Property> Properties { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductProperty> ProductProperty { get; set; }


    }
}