using Eterna.Controllers;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioImage> PortfolioImages { get; set; }


    }
}
