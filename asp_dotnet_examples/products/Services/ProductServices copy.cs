// using Products.Models;

// namespace products.Services
// {
//     public class ProductService
//     {
//         private static readonly List<Product> products = new()
//         {
//             new Product { Id = 1, Name = "Laptop", Price = 899.99M },
//             new Product { Id = 2, Name = "Phone", Price = 499.99M }
//         };

//         public List<Product> GetAll() => products;

//         public Product? Get(int id) => products.FirstOrDefault(p => p.Id == id);

//         public void Add(Product product) => products.Add(product);

//         public void Update(Product updatedProduct)
//         {
//             var index = products.FindIndex(p => p.Id == updatedProduct.Id);
//             if (index != -1)
//                 products[index] = updatedProduct;
//         }

//         public void Delete(int id)
//         {
//             var product = products.FirstOrDefault(p => p.Id == id);
//             if (product != null) products.Remove(product);
//         }
//     }
// }
