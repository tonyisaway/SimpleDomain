namespace Domain
{
    using System.Collections.Generic;

    using Domain.Tests;

    public class Recipe
    {
        IEnumerable<Ingredient> ingredients = new List<Ingredient>();
        public int Id { get; }

        public string PublicName { get; set; }

        public IEnumerable<Ingredient> Ingredients
        {
            get
            {
                return this.ingredients;
            }
        }
    }
}