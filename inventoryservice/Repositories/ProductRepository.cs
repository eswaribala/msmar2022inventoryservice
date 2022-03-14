using inventoryservice.Contexts;
using inventoryservice.Models;
using Microsoft.EntityFrameworkCore;

namespace inventoryservice.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly InventoryContext DbContext;

        public ProductRepository(InventoryContext dbContext)
        {
            DbContext = dbContext;
        }


         public async Task<Product> AddProduct(Product Product)
        {
            var result=DbContext.Products.Add(Product);
            await DbContext.SaveChangesAsync();
            return result.Entity;

        }

        public async void DeleteProduct(long ProductId)
        {
            var result = await DbContext.Products
               .FirstOrDefaultAsync(p => p.ProductId == ProductId);
            if (result != null)
            {
                DbContext.Products.Remove(result);
                await DbContext.SaveChangesAsync();
            }
        }

        public async Task<Product> GetProduct(long ProductId)
        {
            var result = await DbContext.Products
               .FirstOrDefaultAsync(p => p.ProductId == ProductId);
            if (result != null)
                return result;
            return null;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await DbContext.Products.ToListAsync();
           
        }

        public async Task<Product> UpdateProduct(Product Product)
        {
            var result = await DbContext.Products
                .FirstOrDefaultAsync(p => p.ProductId == Product.ProductId);

            if (result != null)
            {
                result.ProductDescription = Product.ProductDescription;
                


                await DbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
