using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class RecipeTester
    {
        [Test]
        public void CanCreateRecipe()
        {
            var recipe = new Recipe();
        }

        [Test]
        public void RecipeHasId()
        {
            var recipe = new Recipe();
            int id = recipe.Id;
        }

        [Test]
        public void RecipeHasPublicName()
        {
            var recipe = new Recipe();
            string publicName = recipe.PublicName;
        }

        [Test]
        public void RecipeHasIngredients()
        {
            var recipe = new Recipe();
            var ingredients = recipe.Ingredients;
            Assert.IsInstanceOf<IEnumerable<Ingredient>>(ingredients);
        }

        [Test]
        public void RecipeIngredientsIsNotNull()
        {
            var recipe = new Recipe();
            var ingredients = recipe.Ingredients;
            Assert.IsNotNull(ingredients);
        }
    }
}
