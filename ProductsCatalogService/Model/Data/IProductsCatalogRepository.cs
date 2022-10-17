using ProductsCatalogService.Model.Entities;

namespace ProductsCatalogService.Model.Data
{
    public interface IProductsCatalogRepository
    {
        List<Product> GetProducts();
        Product GetProduct(int id);

        List<Product> GetProductsByCatagory(string catagory);
        List<Product> GetProductsByBrand(string brand);

        List<Product> GetProductsByColor(string color);
        List<Product> GetProductsByCountry(string country);

        void DeleteProduct(int id);
        void UpdateProduct(Product product);
        void CreateProduct(Product product);
    }
}
