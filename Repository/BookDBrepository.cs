using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Repository
{
    public class BookDBrepository : IBookstorRepository<Book>
    {
        private readonly BookstoreDBContext db;

        public BookDBrepository(BookstoreDBContext db)
        {
            this.db = db;
        }
        public void Add(Book entity)
        {
            
            db.Books.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = Find(id);

            db.Books.Remove(book);
            db.SaveChanges();
        }

        public Book Find(int id)
        {
            var book = db.Books.Include(a => a.Author).SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> GetAll()
        {
            return db.Books.Include(a=> a.Author).ToList();
        }



        public void Update(int id, Book newbook)
        {
            db.Books.Update(newbook);
            db.SaveChanges();

        }

        public IList<Book> Search(string term)
        {
            var books = db.Books.Include(a => a.Author).Where(b => b.Title.Contains(term) || b.Description.Contains(term) || b.Author.FullName.Contains(term)).ToList();
            return books;
        }
    }
}

