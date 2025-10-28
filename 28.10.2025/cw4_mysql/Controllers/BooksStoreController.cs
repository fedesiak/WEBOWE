using cw4_mysql.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw4_mysql.Controllers
{
    public class BooksStoreController : Controller
    {
        private BookRepo _db;
        public BooksStoreController(IConfiguration config)
        {
            _db = new BookRepo(config);
        }

        // GET: BooksStoreController
        public ActionResult Index()
        {
            var books = _db.GetBooks();
            return View(books);
        }

        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                _db.AddBook(book);
                //zapisanie do bazy
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            //usuwanie ksiazki z bazy
            return View();
        }
        [HttpGet]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
        }

    }
}
