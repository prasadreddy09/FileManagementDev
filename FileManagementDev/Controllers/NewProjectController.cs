using FileManagementDev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileManagementDev.Controllers
{
    public class NewProjectController : Controller
    {
        // GET: NewProject
        public ActionResult CreateNewProject()
        {
            var createProjectModel = new CreateProjectModel();
            createProjectModel.ProjectType = GetProjectTypes();
            createProjectModel.ScopeOfWork = GetWorks();

            return View(createProjectModel);
        }

        private List<ProjectTypes> GetProjectTypes()
        {
            //TODO : populate from DB
            return new List<ProjectTypes>() { new ProjectTypes { ProjectTypeId = 1, ProjectTypeText = "Rebar Detailing" },
            new ProjectTypes { ProjectTypeId = 2, ProjectTypeText = "Rebar Estimating" } };
        }

        private List<Works> GetWorks()
        {
            //TODO : populate from DB
            return new List<Works>() { new Works { WorkId = 1, WorkText = "Accessories" },
            new Works { WorkId = 2, WorkText = "Only Foundation" } };
        }
    }
}