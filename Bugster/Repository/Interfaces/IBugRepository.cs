using Bugster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bugster.Repository
{
    public interface IBugRepository
    {
        IEnumerable<Bug> GetAllBugs();
        Bug GetBug(long bugId);
        bool CreateOrUpdateBug(Bug model);
        bool DeleteBug(long bugId);
    }
}
