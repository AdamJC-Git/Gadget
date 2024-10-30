using GadgetCompany.Models;

namespace GadgetCompany.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save(Product product)
        {
            _db.SaveChanges();
        }
    }
}
