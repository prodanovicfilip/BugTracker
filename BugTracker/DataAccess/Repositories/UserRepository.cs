using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using Mapster;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static BugTracker.DataAccess.Entities.User;

namespace BugTracker.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TrackerContext _context;
        public UserRepository(TrackerContext context)
        {
            _context = context;
        }
        public void Add(User user)
        {
            if (user == null) throw new ArgumentNullException("User is null");
            if (_context.Users.FirstOrDefault(s => s.UserName == user.UserName) != null)
            {
                throw new ArgumentException("User already exist");
            }
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            if (id <= 0) throw new ArgumentException("id");
            var entity = _context.Users.FirstOrDefault(u => u.Id == id);
            if (entity == null) throw new ArgumentNullException("Entity not found");

            return entity;
        }

        public void Update(int id, User user)
        {
            if (id <= 0) throw new ArgumentException("id");
            var dbUser = _context.Users.FirstOrDefault(u => u.Id == id);
            if (dbUser == null) throw new Exception();
            // Adapt user(SOURCE).Adapt(DESTINACIJU) Mapira -> dbUser
            user.Adapt(dbUser);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            if (id <= 0) throw new ArgumentException("id < 0");
            var entity = _context.Users.FirstOrDefault(u => u.Id == id);
            if (entity == null)
            {
                throw new ArgumentNullException("Entity does not exist");
            }

            _context.Users.Remove(entity);
            _context.SaveChangesAsync();
        }

        public User Login(string username, string password)
        {
            return _context.Users.FirstOrDefault(s => s.UserName == username && s.Password == password);
        }

        public List<Project> GetProjectsForUser(User user)
        {
            if (user.UserRole == Role.Admin)
            {
                // Admins have access to all projects
                return _context.Projects.ToList();
            }
            else
            {
                // Regular users are assigned to specific projects
                return _context.Projects
                    .Where(p => p.Id == user.ProjectId)
                    .ToList();
            }
        }
    }
}
