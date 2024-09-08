using SuperMarket.Models;

namespace SuperMarket.Data.Repository.IRepository
{
    public interface ICategoryRepository :IRepository<Category>
    {
        void Update(Category obj);
        void Save();
    }
}
