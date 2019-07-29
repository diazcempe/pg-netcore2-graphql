using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using netcore2_graphql.Core.Data;

namespace netcore2_graphql.Helpers
{
    // https://github.com/graphql-dotnet/graphql-dotnet/issues/648#issuecomment-431489339
    public class ContextServiceLocator
    {
        public IProductRepository ProductRepository => _httpContextAccessor.HttpContext.RequestServices.GetRequiredService<IProductRepository>();
        public IProductCategoryRepository ProductCategoryRepository => _httpContextAccessor.HttpContext.RequestServices.GetRequiredService<IProductCategoryRepository>();

        private readonly IHttpContextAccessor _httpContextAccessor;

        public ContextServiceLocator(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
