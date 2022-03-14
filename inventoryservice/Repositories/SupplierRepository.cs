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

        public async Task<Supplier> AddSupplier(Supplier Supplier)
        {
            var result = await DbContext.Suppliers.AddAsync(Supplier);
            await DbContext.SaveChangesAsync();
            return result.Entity;

        }

        public async void DeleteSupplier(long SupplierId)
        {
            var result = await DbContext.Suppliers
                 .FirstOrDefaultAsync(s => s.SupplierId == SupplierId);
            if (result != null)
            {
                DbContext.Suppliers.Remove(result);
                await DbContext.SaveChangesAsync();
            }
        }

        public async Task<Supplier> GetSupplier(long SupplierId)
        {
            var result= await DbContext.Suppliers
                .FirstOrDefaultAsync(s => s.SupplierId == SupplierId);
            if (result != null)
                return result;
            return null;
        }

        public async Task<IEnumerable<Supplier>> GetSuppliers()
        {
            return await DbContext.Suppliers.ToListAsync();
        }

        public async Task<Supplier> UpdateSupplier(Supplier Supplier)
        {
            var result = await DbContext.Suppliers
                .FirstOrDefaultAsync(s => s.SupplierId == Supplier.SupplierId);

            if (result != null)
            {
                result.SupplierName = Supplier.SupplierName;
                

                await DbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
