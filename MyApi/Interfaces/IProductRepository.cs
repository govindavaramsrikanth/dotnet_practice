using MyApi.Models;
using System.Collections.Generic;

namespace MyApi.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
