using SuperMarket.Data.Repository.IRepository;
using SuperMarket.Models;
using System.Linq.Expressions;

namespace SuperMarket.Data.Repository
{
    public class CategoryRepository:Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db):base(db) 
        {
            _db = db;
        }

        

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
          
        }
        public void Save()
        {
            _db.SaveChanges();
        }

      
    }
}
