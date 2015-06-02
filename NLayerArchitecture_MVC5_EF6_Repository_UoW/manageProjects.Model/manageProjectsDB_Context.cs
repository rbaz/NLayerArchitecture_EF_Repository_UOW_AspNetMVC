using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using manageProjects.Model.Models;
using manageProjects.Model.Models.Mapping;

namespace manageProjects.Model
{
    public class ManageProjectsDbContext : DbContext
    {
        public ManageProjectsDbContext()
            : base("ManageProjectsDbContext")
        {

        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<UserStorie> UserStories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new UserStorieMap());
            modelBuilder.Configurations.Add(new ProjectTaskMap());
            modelBuilder.Configurations.Add(new EmployeeMap());

            Database.SetInitializer(new CreateDatabaseIfNotExists<ManageProjectsDbContext>());

            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
        }
    }
}
