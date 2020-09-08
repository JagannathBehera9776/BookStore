using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult GetAllBooks()
        {
           var data= _bookRepository.GetAllBooks();

            return View(data);
        }
        public ViewResult GetBookId(int id)
        {
            var data= _bookRepository.GetBookId(id);

            return View(data);
        }
        public ViewResult AddNewBook()
        {
            return View();


        }
    }
}