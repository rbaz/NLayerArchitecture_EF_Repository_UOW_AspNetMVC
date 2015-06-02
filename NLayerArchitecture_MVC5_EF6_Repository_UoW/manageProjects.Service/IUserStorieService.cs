using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using manageProjects.Model.Models;
using manageProjects.Service.Common;

namespace manageProjects.UI.Web.Controllers
{
    public interface IUserStorieService : IEntityService<UserStorie>
    {
        UserStorie GetById(int id);
    }
}
