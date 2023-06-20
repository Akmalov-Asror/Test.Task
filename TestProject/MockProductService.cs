using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Test.Task.Data;
using Test.Task.Entities;
using Test.Task.Interface;

namespace TestProject
{
    public class MockProductService : IProductService
    {
        private readonly AppDBContext _dbContext;
        public MockProductService()
        {
            _dbContext = new Mock<AppDBContext> ;
        }

        public Product AddProduct(Product model)
        {
            
        }

        public List<Product> GetProduct()
        {
            
        }
    }
}
