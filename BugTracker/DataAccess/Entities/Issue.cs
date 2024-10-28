using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BugTracker.DataAccess.Entities
{
    public class Issue
    {
        public enum PriorityLevel
        {
            Low, Medium, High
        }
        public enum IssueStatus
        {
            Open, Resolved, Closed
        }
        [Key]
        public int Id { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public PriorityLevel Priority { get; set; }
        public IssueStatus Status { get; set; }

        public ICollection<User> Users { get; set; }

        // Foreign key to the Project entity
        public int ProjectId { get; set; }
        // Navigation property for the related Project
        public Project RelatedProject { get; set; }

    }
}
