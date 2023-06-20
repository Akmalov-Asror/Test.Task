using Test.Task.Entities;

namespace Test.Task.Interface;

public interface IProductService
{
    Entities.Product AddProduct(Product model);
    List<Entities.Product> GetProduct();
}