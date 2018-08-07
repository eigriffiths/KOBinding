using KOBinding.model;

namespace KOBinding.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KOBinding.DataLayer.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(KOBinding.DataLayer.SalesContext context)
        {
            context.SalesOrders.AddOrUpdate(
                so => so.CustomerName,
                new SalesOrder { CustomerName = "Adam", PoNumber = "9876" },
                new SalesOrder { CustomerName = "Michael" },
                new SalesOrder { CustomerName = "David", PoNumber = "Acme 9" }
            );
        }
    }
}
