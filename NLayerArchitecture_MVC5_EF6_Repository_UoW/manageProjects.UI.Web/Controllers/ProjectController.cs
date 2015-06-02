using System.Web.Mvc;
using manageProjects.Model.Models;
using manageProjects.Service;

namespace manageProjects.UI.Web.Controllers
{
    public class ProjectController : Controller
    {

        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;

        }

        // GET: /Person/
        public ActionResult Index()
        {
            return View(_projectService.GetAll());
        }

        // GET: /Person/Create
        public ActionResult Create()
        {
            //var viewModels = new MyViewModel();

            return View();
        }

        // POST: /Person/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Name,Phone,Address,State,CountryId")] Person person)
        public ActionResult Create([Bind(Include = "ProjectId,ProjectName,StartDate,EndDate,CustomerName")] Project project)
        {
            if (ModelState.IsValid)
            {
                _projectService.Create(project);
                return RedirectToAction("Index");
            }

            return View(project);
        }
    }
}