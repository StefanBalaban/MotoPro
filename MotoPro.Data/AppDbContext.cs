using Microsoft.EntityFrameworkCore;
using MotoPro.Models;

namespace MotoPro.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Feature> Features { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ws-dell5540-460;Initial Catalog=motopro-db;Integrated Security=True");
        }
    }
}
