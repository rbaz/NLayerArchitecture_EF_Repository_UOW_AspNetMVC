using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using manageProjects.Model.Models;
using manageProjects.Repository;
using manageProjects.UI.Web.Controllers;
using manageProjects.Service.Common;
using manageProjects.Repository.Repositories;

namespace manageProjects.Service
{
    public class UserStorieService : EntityService<UserStorie>, IUserStorieService
    {
        IUnitOfWork _unitOfWork;
        IUserStorieRepository _userStorieRepository;

        public UserStorieService(IUnitOfWork unitOfWork, IUserStorieRepository userStoryRepository)
            : base(unitOfWork, userStoryRepository)
        {
            _unitOfWork = unitOfWork;
            _userStorieRepository = userStoryRepository;
        }


        public UserStorie GetById(int id) {
            return _userStorieRepository.GetById(id);
        }
    }
}
