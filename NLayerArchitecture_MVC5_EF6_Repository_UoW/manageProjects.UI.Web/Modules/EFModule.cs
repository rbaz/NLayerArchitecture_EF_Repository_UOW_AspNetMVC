using Autofac;
using manageProjects.Repository;
using System.Data.Entity;
using manageProjects.Model;
using manageProjects.Model.Models;

namespace manageProjects.UI.Web.Modules
{
    

    public class EFModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());

            builder.RegisterType(typeof(ManageProjectsDbContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();         

        }

    }
}