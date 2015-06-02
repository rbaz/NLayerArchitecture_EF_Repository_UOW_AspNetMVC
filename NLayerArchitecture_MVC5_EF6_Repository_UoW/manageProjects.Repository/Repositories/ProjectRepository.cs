using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using manageProjects.Model.Models;

namespace manageProjects.Repository.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {

        public ProjectRepository(DbContext context)
            : base(context)
        {
           
        }

        public override IEnumerable<Project> GetAll()
        {
            return _entities.Set<Project>(); 
        }

        //public Person GetById(long id)
        public Project GetById(int id)
        {
            //return _dbset.Include(x=>x.Country).Where(x => x.Id == id).FirstOrDefault();
            return _dbset.Include(x => x.ProjectId).FirstOrDefault(x => x.ProjectId == id);
            //return _dbset.Include(x => x.Country).FirstOrDefault(x => x.Id == id); 
        }

        
    }
}
