namespace Domain
{
    using System.Collections.Generic;

    public class Recipe
    {
        IEnumerable<Ingredient> ingredients = new List<Ingredient>();
        public int Id { get; private set; }

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