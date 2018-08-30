﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET: ComicBooks
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                return Redirect("/");
            }
            return Content("Some new content");
        }
    }
}