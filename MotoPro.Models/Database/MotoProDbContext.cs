using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MotoPro.Models.Database
{
    public class MotoProDbContext : DbContext
    {
        //public MotoProDbContext(DbContextOptions<MotoProDbContext> options)
        //    : base(options)
        //{ }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Feature> Features { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ws-dell5540-460;Initial Catalog=motopro-db;Integrated Security=True");
        }
    }
}
