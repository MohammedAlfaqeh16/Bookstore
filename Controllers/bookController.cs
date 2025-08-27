using Bookstore.Models;
using Bookstore.Repository;
using Bookstore.viewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;

namespace Bookstore.Controllers
{
    public class bookController : Controller
    {
        private readonly IBookstorRepository<Book> bookRepository;
        private readonly IBookstorRepository<Author> authrepository;
        private readonly IWebHostEnvironment env;
        //private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment hosting;

        public bookController(IBookstorRepository<Book> bookRepository, IBookstorRepository<Author> Authrepository, IWebHostEnvironment env)
        {
            this.bookRepository = bookRepository;
            authrepository = Authrepository;
            this.env = env;
            //this.hosting = hosting;
        }
        // GET: bookController
        public ActionResult Index()
        {
            var books = bookRepository.GetAll();
            return View(books);
        }

        // GET: bookController/Details/5
        public ActionResult Details(int id)
        {
            return View(bookRepository.Find(id));
        }

        // GET: bookController/Create
        public ActionResult Create()
        {


            return View(getall());
        }

        // POST: bookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(bookAuthorViewModel viewModel)
        {


            if (ModelState.IsValid)
            {
                var auther = authrepository.Find(viewModel.AuthorId);
                try
                {


                    string filename = uploadfile(viewModel.img);
                    Book book = new Book
                    {
                        Id = viewModel.BookId,
                        Title = viewModel.Title,
                        Description = viewModel.Description,
                        Author = auther,
                        imgURL = filename


                    };

                    bookRepository.Add(book);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }



            }
            else
            {
                ModelState.AddModelError("", "الرجاء ملئ الحقول المطلوبة");
                return View(getall());
            }




        }

        // GET: bookController/Edit/5
        public ActionResult Edit(int id)
        {
            var book = bookRepository.Find(id);
            if (book.Author == null)
            {

                book.Author = new Author
                {
                    Id = 0
                };
            }
            var viewModel = new bookAuthorViewModel
            {
                BookId = book.Id,
                Title = book.Title,
                Description = book.Description,
                AuthorId = book.Author.Id,
                Authors = authrepository.GetAll().ToList(),
                imgUrl = book.imgURL

            };
            return View(viewModel);
        }

        // POST: bookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, bookAuthorViewModel model)
        {
            try
            {

                string filename = uploadfile(model.img, model.imgUrl);

                Book book = new Book()
                {
                    Id = model.BookId,
                    Title = model.Title,
                    Description = model.Description,
                    Author = authrepository.Find(model.AuthorId),
                    imgURL = filename
                };

                bookRepository.Update(model.BookId, book);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: bookController/Delete/5
        public ActionResult Delete(int id)
        {
            var book = bookRepository.Find(id);

            return View(book);
        }

        // POST: bookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Book book)
        {
            try
            {

                string uploads = Path.Combine(env.WebRootPath, "uploads");
                string FileName = bookRepository.Find(id).imgURL;
                string fullpath = Path.Combine(uploads, FileName);
                //delate old file
                if (System.IO.File.Exists(fullpath))
                {
                    try
                    {
                        System.IO.File.Delete(fullpath);
                    }
                    catch (IOException)
                    {
                        Thread.Sleep(500);
                        System.IO.File.Delete(fullpath);
                    }
                    //save a new file

                }




                bookRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        bookAuthorViewModel getall()
        {
            var model = new bookAuthorViewModel()
            {
                Authors = authrepository.GetAll().ToList()
            };
            return model;
        }

        string uploadfile(IFormFile file)
        {
            string filename = string.Empty;
            if (file != null)
            {
                string uploads = Path.Combine(env.WebRootPath, "uploads");
                filename = file.FileName;
                string fullpath = Path.Combine(uploads, filename);
                //delate old file
                if (System.IO.File.Exists(fullpath))
                {
                    try
                    {
                        System.IO.File.Delete(fullpath);
                    }
                    catch (IOException)
                    {
                        Thread.Sleep(500);
                        System.IO.File.Delete(fullpath);
                    }
                    //save a new file
                }
                using (var stream = new FileStream(fullpath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                //
                //file.CopyTo(new FileStream(fullpath, FileMode.Create));
                return filename;
            }
            else
            {
                return filename;

            }
        }
        string uploadfile(IFormFile file, string imgURL)
        {
            string filename = string.Empty;
            if (file != null)
            {
                string uploads = Path.Combine(env.WebRootPath, "uploads");
                filename = file.FileName;
                string newfullpath = Path.Combine(uploads, filename);
                string oldfullpath = Path.Combine(uploads, imgURL);
                //delate old file
                if (System.IO.File.Exists(oldfullpath))
                {
                    try
                    {
                        System.IO.File.Delete(oldfullpath);
                    }
                    catch (IOException)
                    {
                        Thread.Sleep(500);
                        System.IO.File.Delete(oldfullpath);
                    }
                    //save a new file
                }
                using (var stream = new FileStream(newfullpath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                //
                //file.CopyTo(new FileStream(fullpath, FileMode.Create));
                return filename;
            }
            else
            {
                return imgURL;
            }

        }
        public ActionResult Search(string term)
        {
            var result = bookRepository.Search(term);
            return View("Index", result);



        }
    }
}
