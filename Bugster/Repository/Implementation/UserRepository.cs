using System;
using System.Collections.Generic;
using System.Linq;
using Bugster.Data;
using Bugster.Models;

namespace Bugster.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        private readonly BugsterDbContext context;

        public UserRepository(BugsterDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<User> GetAllUsers()
        {
            var userList = new List<User>();

            try
            {
                userList = context.Users.OrderBy(usr => usr.Email).ToList();
                return userList;
            }
            catch(Exception ex)
            {
                LogError("GetAllUsers error", ex);
                return userList;
            }
        }

        public IEnumerable<User> GetAllUsersByRoles(List<Role> roles)
        {
            var userList = new List<User>();

            try
            {
                userList = context.Users
                    .Where(usr => roles.Contains(usr.Role))
                    .OrderBy(usr => usr.Email)
                    .ToList();
                return userList;
            }
            catch (Exception ex)
            {
                LogError("GetAllUsers error", ex);
                return userList;
            }
        }
    }
}
