using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using manageProjects.Model.Models;


namespace manageProjects.Repository.Repositories
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        Project GetById(int id);
        //Project Update(Project project, bool loadOriginal = false);
        //Project Insert(Project project);
        //void Delete(manageProjects.Model.Models.Project project);
        //IEnumerable<manageProjects.Model.Models.Project> GetAll();
    }
}
