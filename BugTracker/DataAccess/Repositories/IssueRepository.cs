using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using Mapster;
using Microsoft.EntityFrameworkCore;

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
            return _context.Issues.Include(l => l.Users).Include(p => p.RelatedProject).ToList();
        }

        public Issue GetById(int id)
        {
            if (id <= 0) throw new ArgumentException("id < 0");
            var entity = _context.Issues.Include(l => l.Users).Include(p => p.RelatedProject).FirstOrDefault(i => i.Id == id);
            if (entity == null) throw new ArgumentNullException("Entity not found");

            return entity;
        }

        public void Update(int id, Issue issue)
        {
            if (id <= 0) throw new ArgumentException("id < 0");
            var dbIssue = _context.Issues.FirstOrDefault(i => i.Id == id);
            if (dbIssue == null) throw new ArgumentNullException("Issue not found");
            dbIssue = issue;
            //issue.Adapt(dbIssue);
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
            _context.SaveChanges();
        }

        public void AddUser(int issueId, User user)
        {
            if (issueId <= 0) throw new ArgumentException("id < 0");
            var dbIssue = _context.Issues.FirstOrDefault(i => i.Id == issueId);
            if (dbIssue == null) throw new ArgumentNullException("Issue not found");
            if (user == null)
            {
                throw new ArgumentNullException("User is null");
            }
            if (!dbIssue.Users.Contains(user))
            {
                dbIssue.Users.Add(user);
                _context.SaveChanges();
            }
        }
    }
}
