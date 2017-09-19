using CiderAndCode.Web.DataModels;

namespace CiderAndCode.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CiderAndCode.Web.DataModels.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CiderAndCode.Web.DataModels.AppDbContext context)
        {
            context.Users.AddOrUpdate(
                u => u.Name,
                new User
                {
                    Name = "Not Anessa",
                    Type = UserType.Juicer
                },
                new User
                {
                    Name = "Anessa",
                    Type = UserType.Freeloader
                },
                new User
                {
                    Name = "Nathan",
                    Type = UserType.Coder
                });

            context.AppleFacts.AddOrUpdate(af => af.Fact,
                new AppleFact {Fact = "Opal apples are awesome", Type = AppleType.Opal});
        }
    }
}
