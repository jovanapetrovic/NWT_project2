using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bugster.Repository;
using Bugster.Data;
using Bugster.Models;
using System.Collections.Generic;

namespace Bugster.Controllers
{
    public class BugsController : Controller
    {
        private readonly IBugRepository bugRepository;
        private readonly IProjectRepository projectRepository;
        private readonly IUserRepository userRepository;

        public BugsController(IBugRepository br, IProjectRepository pr, IUserRepository ur)
        {
            bugRepository = br;
            projectRepository = pr;
            userRepository = ur;
        }

        public IActionResult Index()
        {
            var message = TempData["OperationMessage"];
            ViewBag.IsRedirected = message != null;
            ViewBag.IsSuccessfull = message;

            var bugs = bugRepository.GetAllBugs().ToList();
            return View(bugs);
        }

        public IActionResult Details(long id)
        {
            var bug = bugRepository.GetBug(id);
            if (bug == null)
            {
                TempData["OperationMessage"] = false;
                return RedirectToAction("Index");
            }
            return View(bug);
        }

        public IActionResult Delete(long id)
        {
            var bug = bugRepository.GetBug(id);
            if (bug == null)
            {
                TempData["OperationMessage"] = false;
                return RedirectToAction("Index");
            }
            return View(bug);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(long id)
        {
            var success = bugRepository.DeleteBug(id);
            TempData["OperationMessage"] = success;
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            FillReporterDropdownWithDynamicValues();
            FillAssigneeDropdownWithDynamicValues();
            FillProjectDropdownWithDynamicValues();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Reporter,AssigneeId,ProjectId,Title,Description,Status,Priority,DueDate")] Bug bug)
        {
            if (ModelState.IsValid)
            {
                var success = bugRepository.CreateOrUpdateBug(bug);
                TempData["OperationMessage"] = success;
                return RedirectToAction(nameof(Index));
            }
            FillReporterDropdownWithDynamicValues();
            FillAssigneeDropdownWithDynamicValues();
            FillProjectDropdownWithDynamicValues();
            return View(bug);
        }

        public async Task<IActionResult> Edit(long id)
        {
            var bug = bugRepository.GetBug(id);
            if (bug == null)
            {
                TempData["OperationMessage"] = false;
                return RedirectToAction("Index");
            }
            
            FillReporterDropdownWithDynamicValues();
            FillAssigneeDropdownWithDynamicValues();
            FillProjectDropdownWithDynamicValues();
            return View(bug);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Id,Reporter,AssigneeId,ProjectId,Title,Description,Status,Priority,DueDate")] Bug bug)
        {
            if (ModelState.IsValid)
            {
                var success = bugRepository.CreateOrUpdateBug(bug);
                TempData["OperationMessage"] = success;
                return RedirectToAction(nameof(Index));
            }
            FillReporterDropdownWithDynamicValues();
            FillAssigneeDropdownWithDynamicValues();
            FillProjectDropdownWithDynamicValues();
            return View(bug);
        }

        // FILL DROPDOWNS WITH DYNAMIC VALUES

        private void FillProjectDropdownWithDynamicValues()
        {
            ViewBag.Projects = projectRepository.GetAllProjects()
                .Select(x => new ProjectSelectModel
                {
                    Name = x.Name,
                    Id = x.Id
                })
                .ToList();
        }

        private void FillReporterDropdownWithDynamicValues()
        {
            ViewBag.Reporters = userRepository.GetAllUsers().ToList()
                .Select(x => new UserSelectModel
                {
                    Email = x.Email,
                    Id = x.Id
                })
                .ToList();
        }

        private void FillAssigneeDropdownWithDynamicValues()
        {

            List<Role> RolesFilter = new List<Role>
            {
                Role.FE_DEVELOPER,
                Role.BE_DEVELOPER,
                Role.TESTER
            };

            ViewBag.Assignees = userRepository.GetAllUsersByRoles(RolesFilter).ToList()
                .Select(x => new UserSelectModel
                {
                    Email = x.Email,
                    Id = x.Id
                })
                .ToList();
        }
    }
}
