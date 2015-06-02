using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using manageProjects.Model.Models;

namespace manageProjects.Repository.Repositories
{
    public interface IUserStorieRepository : IGenericRepository<UserStorie>
    {
        UserStorie GetById(int id);
    }
}
