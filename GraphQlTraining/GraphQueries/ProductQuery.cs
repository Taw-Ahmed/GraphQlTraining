using GraphQL;
using GraphQL.Types;
using GraphQlTraining.GraphTypes;
using GraphQlTraining.Services;
using GraphQlTraining.Services.Interfaces;

namespace GraphQlTraining.GraphQueries
{
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery(IProductService productService)
        {
            Field<ListGraphType<ProductType>>("menuProducts",
                arguments: new QueryArguments(new QueryArgument<IntGraphType>() { Name = "menuId" })
                , resolve: context => { return productService.GetProductsByMenuId(context.GetArgument<int>("menuId")); });

        }
    }
}
