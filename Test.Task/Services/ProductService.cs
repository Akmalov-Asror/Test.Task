using Test.Task.Data;
using Test.Task.Entities;
using Test.Task.Interface;

namespace Test.Task.Services;

public class ProductService : IProductService
{
    private readonly AppDBContext _context;

    public ProductService(AppDBContext context)
    {
        _context = context;
    }

    public Product AddProduct(Product model)
    {
        var product = new Product()
        {
            Title = model.Title,
            Quantiy = model.Quantiy,
            Price = model.Price
        };
        _context.Products.Add(product);
        _context.SaveChanges();
        return product;

    }

    public List<Product> GetProduct()
    {
       return _context.Products.ToList();

    }
}