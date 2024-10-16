using BugTracker.DataAccess.Entities;

namespace BugTracker.DataAccess.Infrastructure
{
    public interface IProjectRepository
    {
        public void Add(Project project);
        public IEnumerable<Project> GetAll();
        public Project GetById(int id);
        public void Update(int id, Project project);
        public void DeleteById(int id);
    }
}
