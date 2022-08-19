using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : IdentityDbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
{
    base.OnModelCreating(builder);
  builder.Entity<Pet>()
      .HasData(
          new Pet { PetId = 1, Name = "Bandit", Species = "Golden Retriever", Age = 4, Gender = "male" },
          new Pet { PetId = 2, Name = "Sparky", Species = "Boston Terrier", Age = 5, Gender = "male" },
          new Pet { PetId = 3, Name = "Bali", Species = "Balinese-Javanese", Age = 1, Gender = "female" }
);
}

        public DbSet<Pet> Pets { get; set; }
    }
}