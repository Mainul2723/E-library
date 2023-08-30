using E_Library.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Library.Controllers
{
    public class AuthorController : Controller {
        private AuthorGetter db = new AuthorGetter();

        public ActionResult Details(int? id) {
            var author = db.GetAuthorById(id);
            return ((author == null) ? (ActionResult)HttpNotFound() : View(author));
        }
    }
}