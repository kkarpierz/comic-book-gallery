using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicGallery.Controllers {

    public class ComicBookController : Controller {

        public ActionResult Detail() {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday) {
                return Redirect("/ComicBook/Detail");
            }
            return Content("Hello from the Comic Book Controller");
        }

    }

}
