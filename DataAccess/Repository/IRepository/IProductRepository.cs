using GadgetCompany.Models;

namespace GadgetCompany.DataAccess.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Save(Product product);
    }
}
