using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using manageProjects.Model.Models;

namespace manageProjects.Repository.Repositories
{
    public class UserStorieRepository: GenericRepository<UserStorie>, IUserStorieRepository
    {
        public UserStorieRepository(DbContext context)
            : base(context)
        {
           
        }
        public UserStorie GetById(int id)
        {
            return FindBy(x => x.ProjectId == id).FirstOrDefault();            
        }
    }
}
