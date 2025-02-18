using Microsoft.EntityFrameworkCore;
using MusicApi.Models;

namespace MusicApi.Data
{
    public class ApiDbContext:DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext>options): base(options) 
        {
            
        }

        public DbSet<Song> Songs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Life moves on",
                    Language = "English",
                    Duration = "4:35"
                },
                new Song
                {
                    Id = 2,
                    Title = "Happiness overflow",
                    Language = "English",
                    Duration = "3:45"
                },
                new Song
                {
                    Id = 3,
                    Title = "Almighty",
                    Language = "English",
                    Duration = "5:05"
                }
                );
        }
    }
}
