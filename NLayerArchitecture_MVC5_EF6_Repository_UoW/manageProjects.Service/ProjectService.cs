using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using manageProjects.Model.Models;
using manageProjects.Repository;
using manageProjects.Repository.Repositories;
using manageProjects.Service.Common;

namespace manageProjects.Service
{
    public class ProjectService : EntityService<Project>, IProjectService
    {
        IUnitOfWork _unitOfWork;
        IProjectRepository _projectRepository;

        public ProjectService(IUnitOfWork unitOfWork, IProjectRepository projectRepository)
            : base(unitOfWork, projectRepository)
        {
            _unitOfWork = unitOfWork;
            _projectRepository = projectRepository;
        }


        public Project GetById(int Id)
        {
            return _projectRepository.GetById(Id);
        }

    }
}
