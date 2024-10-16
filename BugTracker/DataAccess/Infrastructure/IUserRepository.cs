using BugTracker.DataAccess.Entities;

namespace BugTracker.DataAccess.Infrastructure
{
    public interface IUserRepository
    {
        public void Add(User user);
        public IEnumerable<User> GetAll();
        public User GetById(int id);
        public void Update(int id, User user);
        public void DeleteById(int id);
        public User Login(string username, string password);
    }
}
