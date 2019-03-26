using System;
using System.Collections.Generic;
using System.Linq;
using Bugster.Data;
using Bugster.Models;
using Microsoft.EntityFrameworkCore;

namespace Bugster.Repository
{
    public class ProjectRepository : BaseRepository, IProjectRepository
    {
        private readonly BugsterDbContext context;

        public ProjectRepository(BugsterDbContext ctx)
        {
            context = ctx;
        }

        public bool CreateOrUpdateProject(Project model)
        {
            try
            {
                var dbProject = context.Projects
                    .Where(p => p.Id == model.Id)
                    .FirstOrDefault();

                if (dbProject != null)
                {
                    //project exists, update basic info
                    dbProject.Description = model.Description;
                    dbProject.Name = model.Name;
                    dbProject.CreatorId = model.CreatorId;
                }
                else
                {
                    context.Projects.Add(model);

                }
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                LogError("CreateOrUpdateProject error", ex);
                return false;
            }
        }

        public bool DeleteProject(long projectId)
        {
            try
            {
                var dbProject = context.Projects
                    .Include(p => p.Bugs)
                    .Where(p => p.Id == projectId)
                    .FirstOrDefault();

                if (dbProject != null)
                {
                    context.Bugs.RemoveRange(dbProject.Bugs.ToList());
                    context.Projects.Remove(dbProject);
                }

                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                LogError("DeleteProject error", ex);
                return false;
            }
        }

        public IEnumerable<Project> GetAllProjects()
        {
            var projectList = new List<Project>();
            try
            {
                projectList = context.Projects
                    .OrderBy(proj => proj.Name)
                    .ToList();

                return projectList;
            }
            catch (Exception ex)
            {
                LogError("GetAllProjects error", ex);
                return projectList;
            }
        }

        public IEnumerable<Project> GetAllUserProjects(long userId)
        {
            var projectList = new List<Project>();
            try
            {
                projectList = context.Projects
                    .Include(proj => proj.Bugs)
                    .Include(proj => proj.Creator)
                    .Where(proj => proj.CreatorId == userId)
                    .OrderBy(proj => proj.Name)
                    .ToList();

                return projectList;
            }
            catch (Exception ex)
            {
                LogError("GetAllUserProjects error", ex);
                return projectList;
            }
        }

        public Project GetProject(long projectId)
        {
            var project = new Project();
            try
            {
                project = context.Projects
                    .Include(proj => proj.Creator)
                    .Include(proj => proj.Bugs)
                    .Where(proj => proj.Id == projectId)
                    .FirstOrDefault();

                return project;
            }
            catch (Exception ex)
            {
                LogError("GetProject error", ex);
                return project;
            }
        }
    }
}
