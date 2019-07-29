using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using netcore2_graphql.Core.Models;

namespace netcore2_graphql.Core.Data
{
    public interface IProductCategoryRepository
    {
        Task<ICollection<ProductCategory>> Categories{ get; set; }
    }
}
