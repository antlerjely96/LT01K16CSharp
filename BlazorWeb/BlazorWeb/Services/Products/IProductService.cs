using BlazorWeb.Models;

namespace BlazorWeb.Services.Products;

public interface IProductService
{
    //Lay toan bo
    Task<List<Product>> GetAllProductsAsync();
    //Lay theo id
    Task<Product> GetProductByIdAsync(int Id);
    //Tao
    Task CreateProductAsync(Product product);
    //Sua
    Task UpdateProductAsync(Product product);
    //Xoa
    Task DeleteProductAsync(int Id);
}