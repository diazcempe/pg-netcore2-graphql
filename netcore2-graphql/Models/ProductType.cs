using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using netcore2_graphql.Core.Models;

namespace netcore2_graphql.Models
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(x => x.Id);
            Field(x => x.Name, true);
            Field(x => x.Category.Name).Name("category");
        }
    }
}
