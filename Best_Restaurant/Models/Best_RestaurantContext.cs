using Microsoft.EntityFrameworkCore;

namespace Best_Restaurant.Models
{
  public class Best_RestaurantContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    
    public Best_RestaurantContext(DbContextOptions options) : base(options) { }
  }
}