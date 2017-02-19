namespace Web.Tests
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web.Mvc;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Models;

    using Web.Controllers;

    [TestClass]
    public class WhenCreatingRecipe
    {
        const string ValidRecipeName = "A valid recipe name";

        [TestMethod]
        public void GivenValidRecipeNameThenRecipeIsValid()
        {
            // Arrange
            var recipe = new Recipe { Name = ValidRecipeName };

            var validationContext = new ValidationContext(recipe, null, null);
            var validationResults = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(recipe, validationContext, validationResults, true);

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void GivenInvalidRecipeNameThenResultIsView()
        {
            // Arrange
            var recipe = new Recipe
                             {
                                 Name = null
                             };

            var controller = new RecipesController();

            var validationContext = new ValidationContext(recipe, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(recipe, validationContext, validationResults, true);
            foreach (var validationResult in validationResults)
            {
                controller.ModelState.AddModelError(
                    validationResult.MemberNames.FirstOrDefault() ?? string.Empty,
                    validationResult.ErrorMessage);
            }

            // Act
            var result = controller.Create(recipe);

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }


        [TestMethod]
        public void GivenInvalidRecipeNameThenResultModelIsRecipe()
        {
            // Arrange
            var recipe = new Recipe
            {
                Name = null
            };

            var controller = new RecipesController();

            var validationContext = new ValidationContext(recipe, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(recipe, validationContext, validationResults, true);
            foreach (var validationResult in validationResults)
            {
                controller.ModelState.AddModelError(
                    validationResult.MemberNames.FirstOrDefault() ?? string.Empty,
                    validationResult.ErrorMessage);
            }

            // Act
            var result = controller.Create(recipe) as ViewResult;
            var model = result.Model;

            // Assert
            Assert.AreEqual(model, recipe);
        }

        [TestMethod]
        public void GivenNullRecipeNameThenRecipeIsInvalid()
        {
            // Arrange
            var recipe = new Recipe
            {
                Name = null
            };

            var validationContext = new ValidationContext(recipe, null, null);
            var validationResults = new List<ValidationResult>();

            // Act
            var isValid = Validator.TryValidateObject(recipe, validationContext, validationResults, true);

            // Assert
            Assert.IsFalse(isValid);
        }
    }
}
