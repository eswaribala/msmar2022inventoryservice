using inventoryservice.Contexts;
using inventoryservice.Models;
using Microsoft.EntityFrameworkCore;

namespace inventoryservice.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly InventoryContext DbContext;

        public SupplierRepository(InventoryContext inventoryContext)
        {
            DbContext = inventoryContext;
        }

        public Supplier AddSupplier(Supplier Supplier)
        {
            DbContext.Suppliers.Add(Supplier);
            DbContext.SaveChanges();
            return Supplier;

        }

        public Boolean DeleteSupplier(long SupplierId)
        {
            bool status = false;
            var supplier = DbContext.Suppliers.Find(SupplierId);
            DbContext.Suppliers.Remove(supplier);
            DbContext.SaveChanges();
            if (GetSupplier(SupplierId) == null)
                status = true;
            return status;
        }

        public Supplier GetSupplier(long SupplierId)
        {
            var supplier = DbContext.Suppliers
             
            .FirstOrDefault(x => x.SupplierId == SupplierId);
            return supplier;
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            return DbContext.Suppliers.ToList();
        }

        public Supplier UpdateSupplier(Supplier Supplier)
        {
           DbContext.Suppliers
                .FirstOrDefaultAsync(s => s.SupplierId == Supplier.SupplierId);

           

            return Supplier;
        }
    }
}
