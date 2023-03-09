using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class DineDashContext : DbContext
  {

    public DbSet<Restaurant> Stylists { get; set; }
    public DbSet<Cuisine> Clients { get; set; }
    

    public DineDashContext(DbContextOptions options) : base(options) { }
  }
}