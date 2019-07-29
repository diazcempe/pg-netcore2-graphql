using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using netcore2_graphql.Core.Data;

namespace netcore2_graphql.Models
{
    public class InventoryAppQuery : ObjectGraphType
    {
        public InventoryAppQuery(IProductRepository productRepo)
        {
            Field<ProductType>(
                name: "product",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> {Name = "id"}),
                resolve: context => productRepo.Get(context.GetArgument<int>("id")));

            Field<ListGraphType<ProductType>>(
                name: "products",
                resolve: context => productRepo.All());
        }
    }
}
