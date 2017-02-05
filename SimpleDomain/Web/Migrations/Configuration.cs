namespace Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<Web.Infrastructure.DomainDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Web.Infrastructure.DomainDatabase context)
        {
            context.Ingredients.AddOrUpdate(
                x => x.PublicName, 
                new Ingredient("Onion"), 
                new Ingredient("Tomato"));
        }
    }
}
