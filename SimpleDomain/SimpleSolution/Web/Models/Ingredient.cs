namespace Web.Models
{
    using Interfaces;

    public class Ingredient : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Measure { get; set; }
    }
}