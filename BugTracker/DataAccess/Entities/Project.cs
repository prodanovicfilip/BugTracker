using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.DataAccess.Entities
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Issue> Issues { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
