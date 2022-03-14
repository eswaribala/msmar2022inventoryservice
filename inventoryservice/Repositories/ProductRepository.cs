using inventoryservice.Models;

namespace inventoryservice.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<Product> AddProduct(Product Product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(long ProductId)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProduct(long ProductId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProduct(Product Product)
        {
            throw new NotImplementedException();
        }
    }
}
