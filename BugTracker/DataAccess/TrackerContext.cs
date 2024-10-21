using BugTracker.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.DataAccess
{
    public class TrackerContext : DbContext
    {
        public TrackerContext()
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-EBPQHUK;Initial Catalog=BugTrackerDB;Integrated Security=SSPI;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

        }
    }
}
