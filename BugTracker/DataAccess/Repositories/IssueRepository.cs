using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using Mapster;

namespace BugTracker.DataAccess.Repositories
{
    public class IssueRepository : IIssueRepository
    {
        private readonly TrackerContext _context;
        public IssueRepository(TrackerContext context)
        {
            _context = context;
        }
        public void Add(Issue issue)
        {
            if (issue == null) throw new ArgumentNullException("Issue is null");

            _context.Issues.Add(issue);
            _context.SaveChanges();
        }

        public IEnumerable<Issue> GetAll()
        {
            return _context.Issues.ToList();
        }

        public Issue GetById(int id)
        {
            if (id <= 0) throw new ArgumentException("id < 0");
            var entity = _context.Issues.FirstOrDefault(i => i.Id == id);
            if (entity == null) throw new ArgumentNullException("Entity not found");

            return entity;
        }

        public void Update(int id, Issue issue)
        {
            if (id <= 0) throw new ArgumentException("id < 0");
            var dbIssue = _context.Issues.FirstOrDefault(i => i.Id == id);
            if (dbIssue == null) throw new ArgumentNullException("Issue not found");
            issue.Adapt(dbIssue);
            _context.SaveChanges();
        }
        public void DeleteById(int id)
        {
            if (id <= 0) throw new ArgumentException("id < 0");
            var entity = _context.Issues.FirstOrDefault(i => i.Id == id);
            if (entity == null)
            {
                throw new ArgumentNullException("Entity does not exist");
            }

            _context.Issues.Remove(entity);
            _context.SaveChangesAsync();
        }
    }
}
