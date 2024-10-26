using BugTracker.DataAccess.Entities;

namespace BugTracker.DataAccess.Infrastructure
{
    public interface IIssueRepository
    {
        public void Add(Issue issue);
        public IEnumerable<Issue> GetAll();
        public Issue GetById(int id);
        public void Update(int id, Issue issue);
        public void DeleteById(int id);
        public void AddUser(int issueId, User user);
    }
}
