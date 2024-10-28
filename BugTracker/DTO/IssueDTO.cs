using BugTracker.DataAccess.Entities;

namespace BugTracker.DTO
{
    public class IssueDTO
    {
        public enum PriorityLevel
        {
            Low, Medium, High
        }
        public enum IssueStatus
        {
            Open, Resolved, Closed
        }
        public string Summary { get; set; }
        public PriorityLevel Priority { get; set; }
        public IssueStatus Status { get; set; }

    }
}
