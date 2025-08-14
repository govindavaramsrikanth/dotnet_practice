using System;
using System.Collections.Generic;
using System.Linq;
using Products.Data;
using Products.Models;

namespace Products.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }
    }
}
