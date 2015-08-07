using PluralsightMVC.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PluralsightMVC.Controllers
{
    [Log]
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        public ActionResult Search(string name = "Italian")
        {
            var message = Server.HtmlEncode(name);
            return Content(message);
        }
    }
}
