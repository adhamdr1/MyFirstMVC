namespace Product_Assiment.Models
{
    public class ProductBL
    {
        List<Product> products;

        public ProductBL()
        {
            products = new List<Product>
            {
                new Product { Id = 1, Name = "S25 Ultra", Price = 500m, ImageUrl = "S25 Ultra.png" },
                new Product { Id = 2, Name = "A72", Price = 350m, ImageUrl = "A72.png" },
                new Product { Id = 3, Name = "A56", Price = 400m, ImageUrl = "A56.png" },
                new Product { Id = 4, Name = "A23", Price = 250m, ImageUrl = "A23.jpg" },
                new Product { Id = 5, Name = "A15", Price = 200m, ImageUrl = "A15.png" },
                new Product { Id = 6, Name = "A06", Price = 150m, ImageUrl = "A06.png" },
            };
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }

}
