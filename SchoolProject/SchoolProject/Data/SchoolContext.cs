using Microsoft.EntityFrameworkCore;
using SchoolProject.Objects;
using SchoolProject;
using SchoolProject.Models;

namespace SchoolProject.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }
        public DbSet<Lehrer> Lehrer { get; set; }

        public DbSet<Schueler> Schueler { get; set; }
        public DbSet<Klassenraum> Klassenraeume { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Schueler>()
                .Property(s => s.Name)
                .IsRequired();
        }
    }
}
