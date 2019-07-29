using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using netcore2_graphql.Core.Models;

namespace netcore2_graphql.Core.Data
{
    public interface IProductRepository
    {
        Task<Product> Get(int id);
        Task<ICollection<Product>> All();
        Task<Product> Add(Product product);
    }

    public class ProductRepository : IProductRepository
    {
        public Task<Product> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Product>> All()
        {
            throw new NotImplementedException();
        }

        public Task<Product> Add(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
