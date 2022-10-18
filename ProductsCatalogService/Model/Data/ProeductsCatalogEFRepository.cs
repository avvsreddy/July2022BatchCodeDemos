using ProductsCatalogService.Model.Entities;

namespace ProductsCatalogService.Model.Data
{
    public class ProeductsCatalogEFRepository : IProductsCatalogRepository
    {
        private ProductsCatalogDbContext db = new ProductsCatalogDbContext();
        public void CreateProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            db.Products.Remove(db.Products.Find(id));
            db.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return db.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public List<Product> GetProductsByAvailability()
        {
            return db.Products.Where(p => p.InStock).ToList();
        }

        public List<Product> GetProductsByBrand(string brand)
        {
            return db.Products.Where(p => p.Brand == brand).ToList();
        }

        public List<Product> GetProductsByCatagory(string catagory)
        {
            return db.Products.Where(p => p.Catagory == catagory).ToList();
        }

        public List<Product> GetProductsByColor(string color)
        {
            return db.Products.Where(p => p.Color == color).ToList();
        }

        public List<Product> GetProductsByCountry(string country)
        {
            return db.Products.Where(p => p.Country == country).ToList();
        }

        public void UpdateProduct(Product product)
        {
            db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
