namespace MyMVCApp.Model
{
    /// <summary>
    /// Represents a product displayed in the product catalog.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        public string name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the product description.
        /// </summary>
        public string description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the product price.
        /// </summary>
        public decimal price { get; set; }
    }
}
