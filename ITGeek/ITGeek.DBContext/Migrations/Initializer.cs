using ITGeek.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ITGeek.DBContext.Migrations
{
    internal class Initializer
    {
        internal static void SeedRoles(ApplicationDbContext context)
        {
            string[] roles =
            {
                "Administrator",
                "Manager",
                "Editor",
                "Buyer",
                "Business",
                "Seller",
                "Subscriber",
                "Guest",
                "Student"
            };
            foreach (var role in roles)
            {
                var roleStore = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

                if (!context.Roles.Any(r=> r.Name == role))
                {
                    roleStore.Create(new IdentityRole(role));
                }
            }
        }

        internal static void User(ApplicationDbContext context)
        {
            string userName = "Rostislav";
            string role = "Owner";
            var userRole = new IdentityRole { Id = Guid.NewGuid().ToString(), Name = role };
            context.Roles.Add(userRole);

            var hasher = new PasswordHasher();

            var user = new User
            {
                UserName = userName,
                PasswordHash = hasher.HashPassword("1"),
                Email = "rostislav96@abv.bg",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            user.Roles.Add(new IdentityUserRole {RoleId = userRole.Id,UserId = user.Id});
            context.Users.AddOrUpdate(user);
        }
    }
}