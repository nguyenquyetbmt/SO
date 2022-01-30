using SO.Data.Infrastructure;
using SO.Model.Models;

namespace SO.Data.Respositories
{
    public interface IProductRepository: IRepository<Product>
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}