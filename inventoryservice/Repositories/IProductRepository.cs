using inventoryservice.Models;

namespace inventoryservice.Repositories
{
    public interface IProductRepository
    {
        //CRUD

        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(long ProductId);
        Task<Product> AddProduct(Product Product);
        Task<Product> UpdateProduct(Product Product);
        void DeleteProduct(long ProductId);
    }
}
