using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using netcore2_graphql.Core.Data;
using netcore2_graphql.Core.Models;

namespace netcore2_graphql.Models
{
    public class InventoryAppMutation : ObjectGraphType
    {
        public InventoryAppMutation(IProductRepository productRepo)
        {
            Name = "Mutation";

            Field<ProductType>(
                name: "createProduct", 
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ProductInputType>> { Name = "product" }
                ),
                resolve: context =>
                {
                    var product = context.GetArgument<Product>("product");
                    return productRepo.Add(product);
                });
        }
    }
}
