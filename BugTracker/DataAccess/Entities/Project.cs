using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.DataAccess.Entities
{
    [Index(nameof(ProjectName), IsUnique = true)]
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Navigation property for the issues related to this project
        [JsonIgnore]  // Prevent circular reference on serialization
        public ICollection<Issue> Issues { get; set; }
        // Navigation property for users assigned to this project
        [JsonIgnore]
        public ICollection<User> Users { get; set; }
    }
}
