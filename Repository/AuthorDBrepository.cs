using Bookstore.Models;

namespace Bookstore.Repository
{
    public class AuthorDBrepository : IBookstorRepository<Author>
    {
        private readonly BookstoreDBContext db;

        public AuthorDBrepository(BookstoreDBContext db)
        {
            this.db = db;
        }
        public void Add(Author entity)
        {
           db.Authors.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Authors.Remove(Find(id));
            db.SaveChanges();
        }

        public Author Find(int id)
        {
            var author = db.Authors.SingleOrDefault(a => a.Id == id);
            return author;
        }

        public IList<Author> GetAll()
        {
            return db.Authors.ToList();
        }

        public IList<Author> Search(string term)
        {
            return db.Authors.Where(a => a.FullName.Contains(term)).ToList();
        }

        public void Update(int id, Author newauthor)
        {
            db.Authors.Update(newauthor);
            db.SaveChanges();


        }
    }
}

