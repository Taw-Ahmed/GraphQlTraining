using GraphQL.Types;

namespace GraphQlTraining.GraphQueries
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Field<MenuQuery>("menuQuery", resolve: context => new { });
            Field<ProductQuery>("productQuery", resolve: context => new { });

        }
    }
}
