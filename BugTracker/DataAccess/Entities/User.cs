using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.DataAccess.Entities
{
    [Index(nameof(UserName), IsUnique = true)]
    public class User
    {
        public User()
        {
            
        }
        public enum Role
        {
            Admin, Employee, Manager
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Role UserRole { get; set; }

        [JsonIgnore]
        public ICollection<Project> AssignedProjects { get; set; }

        // Navigation property for the issues assigned to this user
        [JsonIgnore]
        public ICollection<Issue> AssignedIssues { get; set; }
    }
}
