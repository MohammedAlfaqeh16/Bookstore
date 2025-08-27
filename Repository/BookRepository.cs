using Bookstore.Models;

namespace Bookstore.Repository
{
    public class BookRepository : IBookstorRepository<Book>
    {

        List<Book> books;

        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book {
                    Id = 1,
                    Title = "C# in Depth",
                    Description = "A deep dive into C# language features.",
                    imgURL="‏‏لقطة الشاشة (5).png",
                    Author= new Author()

                },
                new Book {
                    Id = 2,
                    Title = "Pro ASP.NET Core MVC",
                    Description = "A comprehensive guide to ASP.NET Core MVC.",
                    imgURL="‏‏لقطة الشاشة (3).png",
                    Author= new Author()
                },
                new Book {
                    Id = 3,
                    imgURL="‏‏لقطة الشاشة (8).png",
                    Title = "Design Patterns in C#",
                    Description = "An introduction to design patterns in C#.",
                    Author= new Author()



                }
            };
        }
        public void Add(Book entity)
        {
            entity.Id = books.Max(b => b.Id) + 1;
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
        }

        public Book Find(int id)
        {
         var book =  books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> GetAll()
        {
           return books;
        }

        public IList<Book> Search(string term)
        {
            return books.Where(b => b.Title.Contains(term) || b.Description.Contains(term) || b.Author.FullName.Contains(term)).ToList();
        }

        public void Update(int id, Book newbook)
        {
            var book = Find(id);
            book.Title = newbook.Title;
            book.Description = newbook.Description;
            book.Author = newbook.Author;
            book.imgURL = newbook.imgURL;

        }
    }
}
