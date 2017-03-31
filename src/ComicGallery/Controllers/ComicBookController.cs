using ComicGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicGallery.Data;

namespace ComicGallery.Controllers {

    public class ComicBookController : Controller {

        ComicBookRepository _comicBookRepository = null;

        public ComicBookController() {
            _comicBookRepository = new ComicBookRepository();
        }


        public ActionResult Detail(int? id) {

            if (id == null) {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);
        }
        
    }

}
