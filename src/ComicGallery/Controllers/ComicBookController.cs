using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicGallery.Controllers {
    public class ComicBookController : Controller {
        public ContentResult Detail() {
            return new ContentResult() {
                Content = "Hello from the comic view controller."
            };
        }
    }
}
