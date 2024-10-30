using Microsoft.EntityFrameworkCore;

namespace GadgetCompany.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> _dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this._dbSet = _db.Set<T>();
        }
        public void Create(T entity)
        {
            _db.Add<T>(entity);
        }

        public T Get(int id)
        {
            return _db.Find<T>(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public void Remove(T entity)
        {
            _db.Remove<T>(entity);
        }
    }
}
