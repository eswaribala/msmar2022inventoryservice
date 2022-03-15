using inventoryservice.Models;

namespace inventoryservice.Repositories
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetSuppliers();
        Task<Supplier> GetSupplier(long SupplierId);
        Task<Supplier> AddSupplier(Supplier Supplier);
        Task<Supplier> UpdateSupplier(Supplier Supplier);
        void DeleteSupplier(long SupplierId);
    }
}
