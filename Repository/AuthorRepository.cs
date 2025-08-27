using Bookstore.Models;

namespace Bookstore.Repository
{
    public class AuthorRepository : IBookstorRepository<Author>
    {

        List<Author> authors;

        public AuthorRepository()
        {
            authors = new List<Author>()
            {
                new Author { Id = 1, FullName = "John Doe" },
                new Author { Id = 2, FullName = "Jane Smith" },
                new Author { Id = 3, FullName = "Alice Johnson" }
            };
        }
        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            authors.Remove(Find(id));
        }

        public Author Find(int id)
        {
           var author = authors.SingleOrDefault(a => a.Id == id);
            return author;
        }

        public IList<Author> GetAll()
        {
            return authors;
        }

        public IList<Author> Search(string term)
        {
             return authors.Where(a => a.FullName.Contains(term)).ToList();
        }

        public void Update(int id, Author newauthor)
        {
            var author = Find(id);
            author.FullName = newauthor.FullName;


        }
    }
}
