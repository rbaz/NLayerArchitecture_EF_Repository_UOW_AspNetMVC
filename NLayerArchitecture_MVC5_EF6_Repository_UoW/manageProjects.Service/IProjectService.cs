using manageProjects.Model.Models;
using manageProjects.Repository.Repositories;
using manageProjects.Service.Common;

namespace manageProjects.Service
{
    public interface IProjectService : IEntityService<Project>
    {
        Project GetById(int Id);

        
    }
}
