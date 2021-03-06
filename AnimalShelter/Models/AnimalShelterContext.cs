using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> animals { get; set; }

    public AnimalShelterContext(DbContextOptions options) : base(options) { }
  }
}