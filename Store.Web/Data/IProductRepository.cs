namespace Store.Web.Data
{
    using System.Linq;
    using System.Threading.Tasks;
    using Store.Web.Data.Entities;

    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers();
        Task<bool> ExistsAsync(int id);
    }
}