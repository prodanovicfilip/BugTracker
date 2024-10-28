using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BugTracker.DataAccess.Entities;

namespace BugTracker.DTO
{
    public class UserDTO
    {
        public enum Role
        {
            Admin, Employee, Manager
        }
        public string UserName { get; set; }
        public string Email { get; set; }
        public Role UserRole { get; set; }
    }
}
