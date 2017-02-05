using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tests
{
    using Moq;

    using NUnit.Framework;

    [TestFixture]
    public class IDataSourceTester
    {
        [Test]
        public void HasInterfaceOfDataSource()
        {
            var datasourceMock = new Mock<IDataSource>();
        }

        [Test]
        public void DataSourceHasQueryableRecipes()
        {
            var datasourceMock = new Mock<IDataSource>();
            IDataSource datasource = datasourceMock.Object;
            IQueryable<Recipe> recipes = datasource.Recipes;
        }


        [Test]
        public void DataSourceHasQueryableUsers()
        {
            var datasourceMock = new Mock<IDataSource>();
            IDataSource datasource = datasourceMock.Object;
            IQueryable<User> users = datasource.Users;
        }

        [Test]
        public void DataSourceHasQueryableIngredients()
        {
            var datasourceMock = new Mock<IDataSource>();
            IDataSource datasource = datasourceMock.Object;
            IQueryable<Ingredient> ingredients = datasource.Ingredients;
        }
    }
}
