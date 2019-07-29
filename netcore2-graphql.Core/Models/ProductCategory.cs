using System;
using System.Collections.Generic;
using System.Text;

namespace netcore2_graphql.Core.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
