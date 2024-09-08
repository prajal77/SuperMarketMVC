using System.Linq.Expressions;

namespace SuperMarket.Data.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //Get All Category
        IEnumerable<T> GetAll();

        //Get Category By Id
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);  
        void RemoveRange(IEnumerable<T> entities);
    }
}
