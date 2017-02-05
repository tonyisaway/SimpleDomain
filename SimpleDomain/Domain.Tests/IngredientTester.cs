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
        private readonly string ValidIngredientPublicName = "ValidPublicName";


        [Test]
        public void IngredientHasId()
        {
            var ingredient = CreateIngredient(this.ValidIngredientPublicName);
            int id = ingredient.Id;
        }

        [Test]
        public void GivenNameWhenCreatingIngredientThenNameWasSet()
        {
            string publicName = "IngredientName";
            var ingredient = CreateIngredient(publicName);
            Assert.AreEqual(ingredient.PublicName, publicName);
        }


        [Test]
        public void GivenNullNameWhenCreatingIngredientThenArgumentNullException()
        {
            TestDelegate td = () => CreateIngredient(null);
            var exception = Assert.Throws<ArgumentNullException>(td);
            Assert.AreEqual(exception.ParamName, "publicName");
        }

        [Test]
        public void GivenEmptyStringWhenCreatingIngredientThenArgumentException()
        {
            TestDelegate td = () => CreateIngredient(string.Empty);
            var exception = Assert.Throws<ArgumentException>(td);
            Assert.AreEqual(exception.ParamName, "publicName");
        }

        private static Ingredient CreateIngredient(string publicName)
        {
            return new Ingredient(publicName);
        }
    }
}
