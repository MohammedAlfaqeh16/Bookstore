using Microsoft.Build.Execution;

namespace Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string imgURL { get; set; }

        public Author Author { get; set; }

    }
}
