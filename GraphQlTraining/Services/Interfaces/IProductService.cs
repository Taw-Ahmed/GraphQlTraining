using GraphQlTraining.Models;

namespace GraphQlTraining.Services.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProductsByMenuId(int menuId);

        Product AddProduct(Product product);
    }
}
