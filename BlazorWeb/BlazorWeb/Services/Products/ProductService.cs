using BlazorWeb.Data;
using BlazorWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWeb.Services.Products;

public class ProductService : IProductService
{
    private readonly AppDbContext _context;
    
    //constructor
    public ProductService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Product>> GetAllProductsAsync()
    {
        return await _context.Products.Include(p => p.category).ToListAsync();
    }

    public async Task<Product> GetProductByIdAsync(int Id)
    {
        return await _context.Products.FindAsync(Id);
    }

    public async Task CreateProductAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProductAsync(Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProductAsync(int Id)
    {
        var product = await GetProductByIdAsync(Id);
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
    }
}