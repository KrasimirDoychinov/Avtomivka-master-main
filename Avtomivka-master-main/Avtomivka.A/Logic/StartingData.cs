namespace Avtomivka.A.Logic
{
    using Avtomivka.A.Data;
    using Avtomivka.A.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using System.Linq;

    public static class StartingData
    {

        public static void CreateStratingData(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            Roles(roleManager);
            Users(userManager);
            Workers(context);
            Programs(context);
            Colons(context);
        }

        public static void Workers(ApplicationDbContext context)
        {
            if (context.Workers.Count() <= 0)
            {
                context.Workers.AddRange(new Worker[]
                {
                    new Worker{Id = "1", Name = "Gosho", Age = 30, Description = "Gosho description", Image = "default1.png"},
                    new Worker{Id = "2", Name = "Pesho", Age = 20, Description = "Pesho description", Image = "default2.png"},
                    new Worker{Id = "3", Name = "Tosho", Age = 40, Description = "Tosho description", Image = "default3.png"},
                });
            }

            context.SaveChanges();
        }

        public static void Programs(ApplicationDbContext context)
        {
            if (context.Programs.Count() <= 0)
            {
                context.Programs.AddRange(new Data.Models.Program[]
                {
                    new Data.Models.Program{Name = "Program1", Description = "Program1 description", Price = 20},
                    new Data.Models.Program{Name = "Program2", Description = "Program2 description", Price = 30},
                    new Data.Models.Program{Name = "Program3", Description = "Program3 description", Price = 40},
                });
            }
            context.SaveChanges();
        }

        public static void Colons(ApplicationDbContext context)
        {
            if (context.Colons.Count() <= 0)
            {
                context.Colons.AddRange(new Colon[]
                {
                    new Colon{Number = 1},
                    new Colon{Number = 2},
                    new Colon{Number = 3},
                    new Colon{Number = 4},
                    new Colon{Number = 5},
                    new Colon{Number = 6},
                    new Colon{Number = 7},
                    new Colon{Number = 8},
                    new Colon{Number = 9},
                });
            }
            context.SaveChanges();
        }
        public static void Users(UserManager<User> userManager)
        {
            if (userManager.FindByNameAsync("User1@gmail.com").Result == null)
            {
                var account = new User
                {
                    UserName = "User1@gmail.com",
                    EmailConfirmed = true,
                    Email = "User1@gmail.com"
                };
                var result = userManager.CreateAsync(account, "User1@gmail.com.").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(account, "User").Wait();
                }
            }

            if (userManager.FindByNameAsync("User2@gmail.com").Result == null)
            {
                var account = new User
                {
                    UserName = "User2@gmail.com",
                    EmailConfirmed = true,
                    Email = "User2@gmail.com"
                };
                var result = userManager.CreateAsync(account, "User2@gmail.com.").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(account, "User").Wait();
                }
            }

            if (userManager.FindByNameAsync("Admin1@gmail.com").Result == null)
            {
                var account = new User
                {
                    UserName = "Admin1@gmail.com",
                    EmailConfirmed = true,
                    Email = "Admin1@gmail.com"
                };
                var result = userManager.CreateAsync(account, "Admin1@gmail.com.").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(account, "Admin").Wait();
                }
            }
        }

        public static void Roles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("User").Result)
            {
                var role = new IdentityRole() { Name = "User" };
                roleManager.CreateAsync(role).Wait();
            }
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                var role = new IdentityRole() { Name = "Admin" };
                roleManager.CreateAsync(role).Wait();
            }
        }
    }
}
