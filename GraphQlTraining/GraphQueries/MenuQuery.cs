using GraphQL;
using GraphQL.Types;
using GraphQlTraining.GraphTypes;
using GraphQlTraining.Services;
using GraphQlTraining.Services.Interfaces;

namespace GraphQlTraining.GraphQueries
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenuService menuService, IProductService productService)
        {
            Field<ListGraphType<MenuType>>("menus", resolve: context => { return menuService.GetMenus(); });

            Field<MenuType>("menu",
                arguments: new QueryArguments(new QueryArgument<IntGraphType>() { Name = "id" })
                , resolve: context => { return menuService.GetMenuById(context.GetArgument<int>("id")); });

            

        }
    }
}
