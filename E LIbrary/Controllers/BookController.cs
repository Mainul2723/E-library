using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Library.Models;
using E_Library.Database;

namespace E_Library.Controllers
{
    public class BookController : Controller
    {
        private BookGetter db = new BookGetter();

        public ActionResult Details(int? id) {
            var book = db.GetBookById(id);
            return ((book == null) ? (ActionResult)HttpNotFound() : View(book));
        }
    }
}