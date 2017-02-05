namespace Domain.Tests
{
    using System.Linq;

    public interface IDataSource
    {
        IQueryable<Recipe> Recipes { get; }

        IQueryable<User> Users { get; }

        IQueryable<Ingredient> Ingredients { get; }
    }
}