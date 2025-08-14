using MyApi.Interfaces;
using MyApi.Models;
using System.Collections.Generic;

namespace MyApi.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAll()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1500 },
                new Product { Id = 2, Name = "Phone", Price = 800 }
            };
        }
    }
}
