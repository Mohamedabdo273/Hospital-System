using Hospital_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Hospital_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var connect = builder.GetConnectionString("MyConnect");
            optionsBuilder.UseSqlServer(connect);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor>().HasMany(x => x.Patients).WithOne(x => x.Doctor);

        }
    }
}
