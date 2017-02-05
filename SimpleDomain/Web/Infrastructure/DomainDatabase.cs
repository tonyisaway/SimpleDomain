using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Infrastructure
{
    using System.Data.Entity;

    using Domain;
    public class DomainDatabase : DbContext, IDataSource
    {
        public DomainDatabase() : base("DefaultConnection")
        {
            
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        IQueryable<Recipe> IDataSource.Recipes
        {
            get
            {
                return Recipes;
            }
        }

        IQueryable<User> IDataSource.Users
        {
            get
            {
                return Users;
            }
        }

        IQueryable<Ingredient> IDataSource.Ingredients
        {
            get
            {
                return Ingredients;
            }
        }

        
    }
}