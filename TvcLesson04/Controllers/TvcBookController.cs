using Humanizer;
using Microsoft.AspNetCore.Mvc;
using TvcLesson04.Models;

namespace TvcLesson04.Controllers
{
    public class TvcBookController : Controller
    {
        protected  Book book= new Book();
        public IActionResult TvcIndex()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;

            var books = book.GetBookList();
            return View(books);
        }
    }
}
