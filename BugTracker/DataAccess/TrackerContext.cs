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
            // One-to-Many: A User can have many assigned Issues
            modelBuilder.Entity<Issue>()
                .HasOne(i => i.AssignedToUser)
                .WithMany(u => u.AssignedIssues)
                .HasForeignKey(i => i.UserId)
                .OnDelete(DeleteBehavior.Restrict);  // Optional: Avoid cascade delete to prevent deleting user when issue is deleted

            modelBuilder.Entity<Issue>()
                .HasOne(i => i.RelatedProject)
                .WithMany(p => p.Issues)
                .HasForeignKey(i => i.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);  

            modelBuilder.Entity<User>()
                .HasOne(u => u.AssignedProject)
                .WithMany(p => p.Users)
                .HasForeignKey(u => u.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);  

            base.OnModelCreating(modelBuilder);

        }
    }
}
