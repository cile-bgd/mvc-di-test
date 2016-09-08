using InterviewTest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterviewTest.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        // GET: Book
        public ActionResult Index()
        {
            PopulateBooksIfNoneExist();
            var books = _bookRepository.GetBooks();

            return View(books);
        }

        private void PopulateBooksIfNoneExist()
        {
            if (!_bookRepository.GetBooks().Any())
            {
                _bookRepository.Add(new Book("Red October", new Author("Tom", "Clancy", 79), new DateTime(1995, 1, 1)));
                _bookRepository.Add(new Book("White Fang", new Author("Jack", "London", 99), new DateTime(1911, 1, 1)));
            }
        }
    }
}