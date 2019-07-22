using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;

namespace netcore2_graphql.Models
{
    public class InventoryAppSchema : Schema
    {
        public InventoryAppSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<InventoryAppQuery>();
            Mutation = resolver.Resolve<InventoryAppMutation>();
        }
    }
}
