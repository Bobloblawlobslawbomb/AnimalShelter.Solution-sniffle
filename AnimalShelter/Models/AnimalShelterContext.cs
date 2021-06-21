using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
        new Animal { AnimalId = 1, Name = "Snickers", Category = "Dog", Intelligence = 1, Temperment = "Good", Friendliness = "Very friendly", Ailment = "Droopy eye" },
        new Animal { AnimalId = 2, Name = "Mochi", Category = "Dog", Intelligence = 4, Temperment = "Good", Friendliness = "Very friendly", Ailment = "none" },
        new Animal { AnimalId = 3, Name = "Bill", Category = "Cat", Intelligence = 3, Temperment = "Lawful good", Friendliness = "Aloof", Ailment = "none" },
        new Animal { AnimalId = 4, Name = "Mrs. Meowsers", Category = "Cat", Intelligence = 3, Temperment = "Mischevious", Friendliness = "Very friendly", Ailment = "Sneezes" }
      );
    }
    public DbSet<Animal> Animals { get; set; }
  }
}