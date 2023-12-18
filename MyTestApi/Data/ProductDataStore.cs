using MyTestApi.Model;

namespace MyTestApi.Data
{
    public static class ProductDataStore
    {
        public static List<Product> Products { get; set; } = new List<Product>();
        static ProductDataStore()
        {
            Products.Add(new Product { Id = 1, Name = "Shirt", Price = 5 });
            Products.Add(new Product { Id = 2, Name = "Skirt", Price = 5 });
            Products.Add(new Product { Id = 3, Name = "Pants", Price = 5 });
        }
    }
}