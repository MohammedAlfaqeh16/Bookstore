using Bookstore.Models;

namespace Bookstore.Repository
{
    public interface IBookstorRepository<T> where T : class
    {
        IList<T> GetAll();
        T Find(int id);

        void Add(T entity);

        void Update(int id,T entity);

        void Delete(int id);
        IList<T> Search(string term);
    }
}
