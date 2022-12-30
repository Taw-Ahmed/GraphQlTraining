using GraphQlTraining.Models;
using GraphQlTraining.Services.Interfaces;

namespace GraphQlTraining.Services
{
    public class ProductService : IProductService
    {
        private List<Product> _products = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name = "OrangeJuice",
                Price = 12.3,
                MenuId = 1,
            },
            new Product
            {
                Id = 2,
                Name = "AppleJuice",
                Price = 15.5,
                MenuId = 1,
            },
            new Product
            {
                Id = 3,
                Name = "Esspresso",
                Price = 10,
                MenuId = 2,
            },
            new Product
            {
                Id = 4,
                Name = "Late",
                Price = 12,
                MenuId = 2,
            },
            new Product
            {
                Id = 5,
                Name = "Burger",
                Price = 20,
                MenuId = 3,
            }
        };
        public Product AddProduct(Product product)
        {
            _products.Add(product);
            return product;
        }

        public List<Product> GetProductsByMenuId(int menuId)
        {
            return _products.Where(p => p.MenuId == menuId).ToList();
        }
    }
}
