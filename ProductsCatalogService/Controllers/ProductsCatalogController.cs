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

        [HttpGet]
        public List<Product> getassdsdf()
        {
            return repo.GetProducts();
        }

        // get products by id
        // GET ....api/productscatalog/234

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = repo.GetProduct(id);
            if (product == null)
            {
                // return 404
                return NotFound();

            }
            // return 200 with data
            return Ok(product);
        }

        // design the suitable URI and create the action methods for the below

        // get products by color
        // GET .../api/productscatalog/color/{color}
        [HttpGet]
        [Route("color/{color}")]
        public ActionResult GetProductsByColor(string color)
        {
            var products = repo.GetProductsByColor(color);
            if (products.Count == 0)
                return NotFound(color);
            return Ok(products);
        }
        // get products by country
        [HttpGet]
        [Route("country/{country}")]
        public ActionResult GetProductsByCountry(string country)
        {
            var products = repo.GetProductsByCountry(country);
            if (products.Count == 0)
                return NotFound(country);
            return Ok(products);
        }

        // get products by availability
        [HttpGet]
        [Route("available")]
        public ActionResult GetProductsByAvailability()
        {
            var products = repo.GetProductsByAvailability();
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }
        // get producgs by brand
        [HttpGet]
        [Route("brand/{brand}")]
        public ActionResult GetProductsByBrand(string brand)
        {
            var products = repo.GetProductsByBrand(brand);
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }
        // get products by catagory
        [HttpGet]
        [Route("catagory/{cat}")]
        public ActionResult GetProductsByCagatory(string cat)
        {
            var products = repo.GetProductsByCatagory(cat);
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }
        // get products by price
        [HttpGet]
        [Route("price/max/{max}/min/{min}")]
        public ActionResult GetProductsByPrice(int min, int max)
        {
            var products = repo.GetProducts().Where(p => p.Price >= min && p.Price <= max).ToList();
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }
        // get costliest product
        [HttpGet]
        [Route("constlies")]
        public ActionResult GetCostliestProducts()
        {
            var product = repo.GetProducts().OrderByDescending(p => p.Price).FirstOrDefault();
            if (product == null)
                return NotFound();
            return Ok(product);
        }
        // get cheapest product
        [HttpGet]
        [Route("cheapest")]
        public ActionResult GetCheapestProducts()
        {
            var product = repo.GetProducts().OrderBy(p => p.Price).FirstOrDefault();
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        // delete product by id

        // DELETE ...api/productscatalog/123
        [HttpDelete]
        [Route("{id}")]
        public ActionResult<Product> DeleteProduct(int id)
        {
            var product = repo.GetProduct(id);
            if (product == null)
            {
                return NotFound(id);
            }
            repo.DeleteProduct(id);
            return Ok();
        }
        // POST ...../api/productscatalog
        [HttpPost]
        public ActionResult Post(Product product)
        {
            // validate
            if (!ModelState.IsValid)
                return BadRequest("invalid input");
            repo.CreateProduct(product);
            // 201+location+data
            return Created($"api/productscatalog/{product.ProductID}", product);
        }

        // PUT ...../api/productscatalog
        [HttpPut]
        public ActionResult Put(Product product)
        {
            // validate
            if (!ModelState.IsValid)
                return BadRequest("invalid input");
            repo.UpdateProduct(product);

            return Ok();
        }
    }
}
