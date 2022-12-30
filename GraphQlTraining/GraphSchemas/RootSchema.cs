using GraphQL.Types;
using GraphQlTraining.GraphQueries;

namespace GraphQlTraining.GraphSchemas
{
    public class RootSchema : Schema
    {
        public RootSchema(IServiceProvider serviceProvider): base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
        }
    }
}
