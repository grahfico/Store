
namespace Store.Web.Data
{
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    using Microsoft.EntityFrameworkCore;

    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly DataContext context;

        public ProductRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable GetAllWithUsers()
        {
            return this.context.Products.Include(p => p.User);
        }
    }
}