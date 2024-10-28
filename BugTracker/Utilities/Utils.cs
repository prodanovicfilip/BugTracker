using System.Linq;
using BugTracker.DataAccess.Entities;

namespace BugTracker.Utilities
{
    public class Utils
    {
        public static bool IsValidString(params string[] values)
        {
            foreach (string value in values)
            {
                if (string.IsNullOrEmpty(value))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsAllowed(Issue issue)
        {
            switch (UserController.CurrentUser.UserRole)
            {
                case User.Role.Admin:
                    return true;
                case User.Role.Employee:
                    return UserController.CurrentUser.AssignedIssues.Contains(issue);
                case User.Role.Manager:
                    return true;
                default:
                    return false;
            }
        }
        public static bool IsAllowed(Project project)
        {
            switch (UserController.CurrentUser.UserRole)
            {
                case User.Role.Admin:
                    return true;
                case User.Role.Employee:
                    return UserController.CurrentUser.AssignedProjects.Contains(project);
                case User.Role.Manager:
                    return true;
                default:
                    return false;
            }
        }
        public static bool IsAllowed()
        {
            switch (UserController.CurrentUser.UserRole)
            {
                case User.Role.Admin:
                    return true;
                case User.Role.Manager:
                    return true;
                default:
                    return false;
            }
        }
    }
}
