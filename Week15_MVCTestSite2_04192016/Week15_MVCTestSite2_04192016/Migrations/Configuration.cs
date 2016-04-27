namespace Week15_MVCTestSite2_04192016.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Week15_MVCTestSite2_04192016.Models.Week15_MVCTestSite2_04192016Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Week15_MVCTestSite2_04192016.Models.Week15_MVCTestSite2_04192016Context";
        }

        protected override void Seed(Week15_MVCTestSite2_04192016.Models.Week15_MVCTestSite2_04192016Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
