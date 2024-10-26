using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.DTO
{
    public class UserWithIssueDTO
    {
        public enum Role
        {
            Admin, Employee, Manager
        }
        public string UserName { get; set; }
        public Role UserRole { get; set; }
        public bool HasIssue { get; set; }
    }
}
