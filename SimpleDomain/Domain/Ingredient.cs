namespace Domain
{
    using System;

    public class Ingredient
    {
        private Ingredient()
        {
        }

        public Ingredient(string publicName)
        {
            if (publicName == null)
            {
                throw new ArgumentNullException(nameof(publicName));
            }

            if (publicName == string.Empty)
            {
                throw new ArgumentException("Must not be an empty string.", nameof(publicName));
            }

            this.PublicName = publicName;
        }

        public int Id { get; private set; }

        public string PublicName { get; private set; }
    }
}