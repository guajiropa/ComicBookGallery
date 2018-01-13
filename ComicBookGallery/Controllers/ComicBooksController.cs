using ComicBookGallery.Models;
using ComicBookGallery.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRespository _comicBookRespository = null;

        public ComicBooksController()
        {
            _comicBookRespository = new ComicBookRespository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRespository.GetComicBooks();

            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRespository.GetComicBook(id.Value);
            
            return View(comicBook);
        }
    }
}