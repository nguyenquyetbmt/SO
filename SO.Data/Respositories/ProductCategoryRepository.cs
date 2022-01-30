using SO.Data.Infrastructure;
using SO.Model.Models;
using System.Collections.Generic;
using System.Linq;
using static SO.Data.Respositories.ProductCategoryRepository;

namespace SO.Data.Respositories
{
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRespsitory
    {
        public interface IProductCategoryRespsitory
        {
            IEnumerable<ProductCategory> GetByAlias(string alias);
        }

        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}