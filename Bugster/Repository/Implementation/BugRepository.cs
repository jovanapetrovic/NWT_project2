using System;
using System.Collections.Generic;
using System.Linq;
using Bugster.Data;
using Bugster.Models;
using Microsoft.EntityFrameworkCore;

namespace Bugster.Repository
{
    public class BugRepository : BaseRepository, IBugRepository
    {
        private readonly BugsterDbContext context;

        public BugRepository(BugsterDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Bug> GetAllBugs()
        {
            var bugList = new List<Bug>();
            try
            {
                bugList = context.Bugs
                    .OrderBy(bug => bug.DueDate)
                    .ToList();

                return bugList;
            }
            catch (Exception ex)
            {
                LogError("GetAllBugs error", ex);
                return bugList;
            }
        }

        public Bug GetBug(long bugId)
        {
            var bug = new Bug();
            try
            {
                bug = context.Bugs
                    .Include(b => b.Project)
                    .Include(b => b.Assignee)
                    .Where(b => b.Id == bugId)
                    .FirstOrDefault();

                return bug;
            }
            catch (Exception ex)
            {
                LogError("GetBug error", ex);
                return bug;
            }
        }

        public bool CreateOrUpdateBug(Bug model)
        {
            try
            {
                var bug = context.Bugs
                    .Where(p => p.Id == model.Id)
                    .FirstOrDefault();

                if (bug != null)
                {
                    //bug exists, update basic info
                    bug.Reporter = model.Reporter;
                    bug.AssigneeId = model.AssigneeId;
                    bug.ProjectId = model.ProjectId;
                    bug.Title = model.Title;
                    bug.Description = model.Description;
                    bug.Status = model.Status;
                    bug.Priority = model.Priority;
                    bug.DueDate = model.DueDate;
                }
                else
                {
                    //model.DateCreated = DateTime.Now;
                    context.Bugs.Add(model);
                }
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                LogError("CreateOrUpdateBug error", ex);
                return false;
            }
        }

        public bool DeleteBug(long bugId)
        {
            try
            {
                var bug = context.Bugs
                    .Where(b => b.Id == bugId)
                    .FirstOrDefault();

                if (bug != null)
                {
                    context.Bugs.Remove(bug);
                }

                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                LogError("DeleteBug error", ex);
                return false;
            }
        }

    }
}
