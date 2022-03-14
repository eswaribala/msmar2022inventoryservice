using inventoryservice.Models;
using inventoryservice.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace inventoryservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierRepository SupplierRepository;

        public SupplierController(ISupplierRepository SupplierRepository)
        {
            this.SupplierRepository = SupplierRepository;
        }

        // GET: api/<SupplierController>
        [HttpGet]
        public Task<IEnumerable<Supplier>> Get()
        {
            return SupplierRepository.GetSuppliers();
        }

        // GET api/<SupplierController>/5
        [HttpGet("{SupplierId}")]
        public Task<Supplier> Get(long SupplierId)
        {
            return SupplierRepository.GetSupplier(SupplierId);
        }

        // POST api/<SupplierController>
        [HttpPost]
        public IActionResult Post([FromBody] Supplier Supplier)
        {
            using (var scope = new TransactionScope())
            {
                SupplierRepository.AddSupplier(Supplier);
                scope.Complete();
                return CreatedAtAction(nameof(Get),
                    new { id = Supplier.SupplierId}, Supplier);
            }
        }

        // PUT api/<SupplierController>/5
        [HttpPut()]
        public IActionResult Put([FromBody] Supplier Supplier)
        {
            if (Supplier != null)
            {
                using (var scope = new TransactionScope())
                {
                    SupplierRepository.UpdateSupplier(Supplier);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        // DELETE api/<SupplierController>/5
        [HttpDelete("{SupplierId}")]
        public IActionResult Delete(long SupplierId)
        {
            SupplierRepository.DeleteSupplier(SupplierId);
            return new OkResult();
        }
    }
}
