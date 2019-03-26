using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Bugster.Data;
using Bugster.Models;
using Microsoft.AspNetCore.Cors;

namespace Bugster.Controllers
{
    [EnableCors("AllowLocalhostAsOrigin")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly BugsterDbContext _dbContext;

        public UsersController(BugsterDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return _dbContext.Users;
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(long id)
        {
            return _dbContext.Users.Find(id);
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody] User user)
        {
            _dbContext.Add(user);
            _dbContext.SaveChanges();
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public void Put(long id, [FromBody] User user)
        {
            User userById = _dbContext.Users.Find(id);
        
            if (userById != null)
            {
                userById.Username = user.Username;
                userById.Password = user.Password;
                userById.Email = user.Email;
                userById.FullName = user.FullName;
                userById.Role = user.Role;
            }
            else
            {
                _dbContext.Users.Add(user);
            }

            _dbContext.SaveChanges();
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            User userById = _dbContext.Users.Find(id);
            if (userById != null)
            {
                _dbContext.Remove(userById);
            }
        }
    }
}
