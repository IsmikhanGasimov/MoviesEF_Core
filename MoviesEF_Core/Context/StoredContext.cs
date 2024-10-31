using Microsoft.EntityFrameworkCore;
using MoviesEF_Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MoviesEF_Core.Context
{
    public class StoredContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ASUS\SQLEXPRESS;Database=MoviesEFCoreTask;Trusted_Connection=Yes;TrustServerCertificate=True");

        }

        public DbSet<Movies> Moviess { get; set; }
        public DbSet<Directors> Directorss { get; set; }
        public DbSet<Subtitles> Subtitless { get; set; }
        public DbSet<MovieSubtitle> MovieSubtitles { get; set; }
        public DbSet<MoviesImdbDetail> MoviesImdbDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}
