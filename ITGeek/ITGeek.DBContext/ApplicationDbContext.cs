using ITGeek.DBContext.Migrations;
using ITGeek.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;


namespace ITGeek.DBContext
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base("ITGeekConnection", throwIfV1Schema: false)
           // : base("ITGeek-DevConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
