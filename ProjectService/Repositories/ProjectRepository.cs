using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectService.Models;
namespace ProjectService.Repositories
{
    public class ProjectRepository
    {
        OrganisationContext db = new OrganisationContext();
        public List<Project> GetAll()
        {
            return db.Project.ToList();
        }
        public Project GetProject(int Pid)
        {
            return db.Project.Find(Pid);
        }
        public void AddProject(Project prj)
        {
            db.Project.Add(prj);
            db.SaveChanges();
        }
        public void UpdateProject(Project prj)
        {
            db.Project.Update(prj);
            db.SaveChanges();
        }
        public void DeleteProject(int Pid)
        {
            Project prj = db.Project.Find(Pid);
            db.Project.Remove(prj);
            db.SaveChanges();
        }
    }
}
