using GraphQL.Types;
using GraphQlTraining.Models;

namespace GraphQlTraining.GraphTypes
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.Description);
            Field(p => p.Price);
            Field(p => p.ImageURL);
            Field(p => p.MenuId);

        }
    }
}
