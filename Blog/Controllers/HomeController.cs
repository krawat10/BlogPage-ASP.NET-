using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var albumy = new List<Album>
            {
                new Album {Artist = "U2", AlbumName = "Nowhere to go" },
                new Album {Artist = "Peja", AlbumName = "Policja" }
            };
            ViewBag.Albumy = albumy;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}