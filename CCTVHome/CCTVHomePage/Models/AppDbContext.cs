using Microsoft.EntityFrameworkCore;

namespace CCTVHomePage.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Comment> Comments { get; set; }
        
    }
}
