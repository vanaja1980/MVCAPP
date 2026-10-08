using MyMVCApp.Model;

namespace MyMVCApp.Repositories
{
    /// <summary>
    /// Provides access to the sample product catalog.
    /// </summary>
    public static class ProductRepository
    {
        private static readonly List<Product> products = new()
        {
            new Product { id = 1, name = "Classic Jacket", description = "A versatile everyday jacket.", price = 79.99m },
            new Product { id = 2, name = "Wool Coat", description = "A warm coat for cooler days.", price = 129.99m },
            new Product { id = 3, name = "Lightweight Hoodie", description = "A comfortable layer for casual wear.", price = 49.99m }
        };

        /// <summary>
        /// Gets all products in the catalog.
        /// </summary>
        /// <returns>The catalog products.</returns>
        public static IReadOnlyList<Product> GetProducts() => products;
    }
}
