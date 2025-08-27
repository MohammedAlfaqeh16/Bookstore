using Bookstore.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Bookstore.viewModel
{
    public class bookAuthorViewModel
    {
       
        
        public int BookId { get; set; }

        [Required(ErrorMessage = "العنوان ضروري!")]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public int AuthorId { get; set; }

        [ValidateNever]
        public List<Author> Authors { get; set; }

        public IFormFile img { get; set; }

        [ValidateNever]
        public string imgUrl { get; set; }

    }
}
