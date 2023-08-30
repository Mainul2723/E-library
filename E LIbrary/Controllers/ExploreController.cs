using E_Library.Database;
using E_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Library.Controllers
{
    public class ExploreController : Controller
    {
        private BookGetter db = new BookGetter();

        public ActionResult Index(string sort, int? _page) {
            if (String.IsNullOrWhiteSpace(sort)) sort = "Title";

            int page = _page ?? 1;
            return View(new Explore() {
                Books = db.GetBooks(page, sort)
            });
        }
    }
}