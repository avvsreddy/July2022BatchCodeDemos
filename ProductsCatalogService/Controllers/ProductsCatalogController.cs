using Microsoft.AspNetCore.Mvc;
using ProductsCatalogService.Model.Data;
using ProductsCatalogService.Model.Entities;

namespace ProductsCatalogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsCatalogController : ControllerBase
    {
        IProductsCatalogRepository repo = new ProeductsCatalogEFRepository();

        //MVC...ProductsCatalog/GetProducts
        //Web API  GET .../api/ProductsCatalog

        //[HttpGet]
        public List<Product> getassdsdf()
        {
            return repo.GetProducts();
        }

        // get products by id
        // GET ....api/productscatalog/234

        [HttpGet]
        [Route("{id}")]
        public Product GetProduct(int id)
        {
            return repo.GetProduct(id);
        }

        // design the suitable URI and create the action methods for the below

        // get products by color
        // get products by country
        // get products by availability
        // get producgs by brand
        // get products by catagory
        // get products by price
        // get costliest product
        // get cheapest product

    }
}
