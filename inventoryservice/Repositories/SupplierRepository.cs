using inventoryservice.Models;

namespace inventoryservice.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        public Task<Supplier> AddSupplier(Supplier Supplier)
        {
            throw new NotImplementedException();
        }

        public void DeleteSupplier(long SupplierId)
        {
            throw new NotImplementedException();
        }

        public Task<Supplier> GetSupplier(long SupplierId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Supplier>> GetSuppliers()
        {
            throw new NotImplementedException();
        }

        public Task<Supplier> UpdateSupplier(Supplier Supplier)
        {
            throw new NotImplementedException();
        }
    }
}
