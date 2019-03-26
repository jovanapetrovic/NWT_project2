using System.Linq;
using System.Threading.Tasks;
using Bugster.Repository;
using Microsoft.AspNetCore.Mvc;
using Bugster.Models;
using System.Collections.Generic;

namespace Bugster.Controllers
{
    [Route("[controller]/[action]")]
    public class ProjectController : Controller
    {
        private readonly IProjectRepository projectRepository;
        private readonly IUserRepository userRepository;

        public ProjectController(IProjectRepository pr, IUserRepository ur)
        {
            projectRepository = pr;
            userRepository = ur;
        }

        public IActionResult Index()
        {
            var message = TempData["OperationMessage"];
            ViewBag.IsRedirected = message != null;
            ViewBag.IsSuccessfull = message;

            List<Role> RolesFilter = new List<Role>
            {
                Role.MANAGER
            };

            var users = userRepository.GetAllUsersByRoles(RolesFilter).ToList();

            return View(users);
        }

        public IActionResult UserProjects(long userId)
        {
            var projects = projectRepository.GetAllUserProjects(userId);
            return View(projects);
        }

        public IActionResult Details(long projectId)
        {
            var project = projectRepository.GetProject(projectId);
            if (project == null)
            {
                TempData["OperationMessage"] = false;
                return RedirectToAction("Index");
            }
            return View(project);
        }

        public IActionResult Delete(long projectId)
        {
            var success = projectRepository.DeleteProject(projectId);
            TempData["OperationMessage"] = success;
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            FillProjectCreatorDropdownWithDynamicValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CreatorId,Name,Description")] Project project)
        {
            if (ModelState.IsValid)
            {
                var success = projectRepository.CreateOrUpdateProject(project);
                TempData["OperationMessage"] = success;
                return RedirectToAction(nameof(Index));
            }
            FillProjectCreatorDropdownWithDynamicValues();
            return View(project);
        }

        public IActionResult Edit(long projectId)
        {
            var project = projectRepository.GetProject(projectId);
            if (project == null)
            {
                TempData["OperationMessage"] = false;
                return RedirectToAction("Index");
            }

            FillProjectCreatorDropdownWithDynamicValues();
            return View(project);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Id,CreatorId,Name,Description")] Project project)
        {
            if (ModelState.IsValid)
            {
                var success = projectRepository.CreateOrUpdateProject(project);
                TempData["OperationMessage"] = success;
                return RedirectToAction("UserProjects", new { userId = project.CreatorId });
            }
            FillProjectCreatorDropdownWithDynamicValues();
            return View(project);
        }

        // FILL DROPDOWNS WITH DYNAMIC VALUES

        private void FillProjectCreatorDropdownWithDynamicValues()
        {
            List<Role> RolesFilter = new List<Role>
            {
                Role.MANAGER
            };

            ViewBag.Users = userRepository.GetAllUsersByRoles(RolesFilter).ToList()
                .Select(x => new UserSelectModel
                {
                    Email = x.Email,
                    Id = x.Id
                })
                .ToList();
        }
    }
}
