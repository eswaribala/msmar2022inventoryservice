using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace inventoryservice.Controllers
{
   

    // [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    //[Route("api/inventory")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        IList<String> products,catalogs;

        public InventoryController()
        {
            products = new List<String>();
            catalogs = new List<String>();
            products.Add("TV");
            products.Add("Table");
            catalogs.Add("Electronics");
            catalogs.Add("Furniture");
        }
        
        [HttpGet]
        [ApiVersion("1")]
        [Route("Products")]
        public IEnumerable<String> GetProducts()
        {
            return products;
        }

      
        [ApiVersion("2")]
        [HttpGet]
        [Route("Catalogs")]
        public IEnumerable<String> GetCatalogs()
        {
            return catalogs;
        }
    }
}
