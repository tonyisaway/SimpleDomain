using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class IngredientTester
    {
        [Test]
        public void CanCreateIngredient()
        {
            var ingredient = new Ingredient();
        }

        [Test]
        public void IngredientHasId()
        {
            var ingredient = new Ingredient();
            int id = ingredient.Id;
        }

        [Test]
        public void IngredientHasPublicName()
        {
            var ingredient = new Ingredient();
            string publicName = ingredient.PublicName;
        }
    }
}
