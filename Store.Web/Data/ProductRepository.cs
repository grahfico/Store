

namespace Store.Web.Data
{

    using Entities;
    using System.Threading.Tasks;

    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
