using ProductsCatalogService.Model.Entities;

namespace ProductsCatalogService.Model.Data
{
    public class ProductsCatalogTestRepository : IProductsCatalogRepository
    {


        private List<Product> products = new List<Product>();
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            products.Add(new Product { ProductID = 111, Name = "Test Product 1" });
            products.Add(new Product { ProductID = 222, Name = "Test Product 2" });
            products.Add(new Product { ProductID = 333, Name = "Test Product 3" });
            products.Add(new Product { ProductID = 444, Name = "Test Product 5" });
            products.Add(new Product { ProductID = 555, Name = "Test Product 5" });
            return products;
        }

        public List<Product> GetProductsByAvailability()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByBrand(string brand)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCatagory(string catagory)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByColor(string color)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCountry(string country)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
