using Microsoft.EntityFrameworkCore;
namespace DogBreed.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<DogBreed> DogBreeds { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedDogsFromJson(); // Custom extension call
        }
    }
}
