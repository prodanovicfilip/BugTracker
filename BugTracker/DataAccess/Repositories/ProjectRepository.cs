using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.DataAccess.Entities;
using BugTracker.DataAccess.Infrastructure;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace BugTracker.DataAccess.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly TrackerContext _context;
        public ProjectRepository(TrackerContext context)
        {
            _context = context;
        }
        public void Add(Project project)
        {
            if (project == null) throw new ArgumentNullException("Project is null");
            if (_context.Projects.FirstOrDefault(p => p.ProjectName == project.ProjectName) != null)
            {
                throw new ArgumentException("Project already exist");
            }
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public IEnumerable<Project> GetAll()
        {
            return _context.Projects.Include(p => p.Users).Include(k => k.Issues).ToList();
        }

        public Project GetById(int id)
        {
            if (id <= 0) throw new ArgumentException("id < 0");
            var entity = _context.Projects.Include(p => p.Users).Include(k => k.Issues).FirstOrDefault(p => p.Id == id);
            if (entity == null) throw new ArgumentNullException("Entity not found");

            return entity;
        }

        public void Update(int id, Project project)
        {
            if (id <= 0) throw new ArgumentException("id < 0");
            var dbProject = _context.Projects.FirstOrDefault(p => p.Id == id);
            if (dbProject == null) throw new ArgumentNullException("Project not found");
            project.Adapt(dbProject);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            if (id <= 0) throw new ArgumentException("id < 0");
            var entity = _context.Projects.FirstOrDefault(p => p.Id == id);
            if (entity == null)
            {
                throw new ArgumentNullException("Entity does not exist");
            }

            _context.Projects.Remove(entity);
            _context.SaveChanges();
        }
    }
}
