using Bugster.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bugster.Data
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<BugsterDbContext>();
                context.Database.EnsureCreated();
                //context.Database.Migrate();

                context.Users.RemoveRange(context.Users.ToList());
                context.Projects.RemoveRange(context.Projects.ToList());
                context.Bugs.RemoveRange(context.Bugs.ToList());

                var managers = GetManagers().ToArray();
                var users = GetUsers().ToArray();
                context.Users.AddRange(managers);
                context.Users.AddRange(users);

                foreach (var manager in managers)
                {
                    context.Projects.AddRange(GenerateRandomProjects(manager.Id));
                }

                context.SaveChanges();
            }
        }

        public static List<User> GetManagers()
        {
            List<User> managers = new List<User>() {
                new User
                {
                    Username = "johnmanager",
                    Password = "ASDasd123",
                    Email = "johnmanager@mailinator.com",
                    FullName = "John Manager",
                    Role = Role.MANAGER,
                },
                new User
                {
                    Username = "katemanager",
                    Password = "ASDasd123",
                    Email = "katemanager@mailinator.com",
                    FullName = "Kate Manager",
                    Role = Role.MANAGER,
                },
                new User
                {
                    Username = "sammanager",
                    Password = "ASDasd123",
                    Email = "sammanager@mailinator.com",
                    FullName = "Sam Manager",
                    Role = Role.MANAGER,
                }
            };
            return managers;
        }

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>() {
                new User {
                    Username = "davefrontend",
                    Password = "ASDasd123",
                    Email = "davefrontend@mailinator.com",
                    FullName = "Dave Frontend",
                    Role = Role.FE_DEVELOPER
                },
                new User {
                    Username = "nickbackend",
                    Password = "ASDasd123",
                    Email = "nickbackend@mailinator.com",
                    FullName = "Nick Backend",
                    Role = Role.BE_DEVELOPER
                },
                new User {
                    Username = "janetester",
                    Password = "ASDasd123",
                    Email = "janetester@mailinator.com",
                    FullName = "Jane Tester",
                    Role = Role.TESTER
                }
            };
            return users;
        }

        private static List<Project> GenerateRandomProjects(long creator)
        {
            List<Project> projects = new List<Project>();

            var rand = new Random();
            var numberOfProjects = rand.Next(1, 6);

            for (int i = 0; i < numberOfProjects; i++)
            {
                var project = new Project()
                {
                    CreatorId = creator,
                    Description = $"Project description: {Guid.NewGuid()}{Guid.NewGuid()}{Guid.NewGuid()}",
                    Name = $"Project named: {Guid.NewGuid()}",
                    Bugs = new List<Bug>(),
                };

                var numberOfBugs = rand.Next(0, 6);

                for (int j = 0; j < numberOfBugs; j++)
                {
                    var v = Enum.GetValues(typeof(Priority));

                    project.Bugs.Add(new Bug()
                    {
                        Description = $"Problem with: {Guid.NewGuid()}",
                        DueDate = DateTime.Now.AddDays(numberOfBugs),
                        Title = $"Bug ID: {Guid.NewGuid()}",
                        Priority = (Priority)v.GetValue(new Random().Next(v.Length)),
                        DateCreated = DateTime.Now,
                        Reporter = "janetester@mailinator.com",
                        ProjectId = project.Id
                    });
                }

                projects.Add(project);
            }

            return projects;
        }
    }
}
