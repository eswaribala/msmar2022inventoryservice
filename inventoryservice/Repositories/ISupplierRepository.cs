using inventoryservice.Models;

namespace inventoryservice.Repositories
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> GetSuppliers();
         Supplier GetSupplier(long SupplierId);
        Supplier AddSupplier(Supplier Supplier);
        Supplier UpdateSupplier(Supplier Supplier);
        Boolean DeleteSupplier(long SupplierId);
    }
}
