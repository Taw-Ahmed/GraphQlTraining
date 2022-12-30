using GraphQL.Types;
using GraphQlTraining.Models;
using GraphQlTraining.Services;
using GraphQlTraining.Services.Interfaces;

namespace GraphQlTraining.GraphTypes
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(IProductService productService)
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageURL);
            Field<ListGraphType<ProductType>>("menuProducts", resolve: context => { return productService.GetProductsByMenuId(context.Source.Id); });

        }
    }
}
