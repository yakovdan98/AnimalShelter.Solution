using Microsoft.EntityFrameworkCore;


namespace ShelterApi.Models
{
  public class ShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public ShelterApiContext(DbContextOptions<ShelterApiContext> options) : base(options)
    {
    }
  }
}