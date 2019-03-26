using Bugster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bugster.Repository
{
    public interface IProjectRepository
    {
        Project GetProject(long projectId);
        IEnumerable<Project> GetAllProjects();
        IEnumerable<Project> GetAllUserProjects(long userId);
        bool CreateOrUpdateProject(Project model);
        bool DeleteProject(long projectId);
    }
}
