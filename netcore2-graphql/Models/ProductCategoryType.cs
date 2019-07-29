using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using netcore2_graphql.Core.Models;
using netcore2_graphql.Helpers;

namespace netcore2_graphql.Models
{
    public class ProductCategoryType : ObjectGraphType<ProductCategory>
    {
        public ProductCategoryType(ContextServiceLocator contextServiceLocator)
        {
            Field(x => x.Id);
            Field(x => x.Name, true);
            Field<ListGraphType<ProductType>>("products",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => contextServiceLocator.ProductRepository.Get(context.Source.Id), description: "Products");
        }
    }
}
