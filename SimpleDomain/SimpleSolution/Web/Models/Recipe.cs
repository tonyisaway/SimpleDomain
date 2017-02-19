namespace Web.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Interfaces;

    public class Recipe : IEntity
    {
        public int Id { get; set; }

        [Required]
        //[StringLength(25, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Name { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}