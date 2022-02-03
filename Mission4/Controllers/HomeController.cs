using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext maContext { get; set; }

        public HomeController(MovieFormContext someName)
        {
            maContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyPodcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = maContext.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(MovieEntry me)
        {
            ViewBag.Categories = maContext.Categories.ToList();
            maContext.Add(me);
            maContext.SaveChanges();

            return RedirectToAction("MovieList"); //changed from movieform and took out me changed view to redirect
        }

        //[HttpGet]
        public IActionResult MovieList ()
        {

            var entries = maContext.Entries
                .Include(x=> x.Category)
                //.OrderBy(x=>x.Title)
                .ToList();
            return View(entries);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = maContext.Categories.ToList();
            var entry = maContext.Entries.Single(x => x.MovieID == movieid);//this line is the error sequence has no element
            return View("MovieForm", entry);
        }
        [HttpPost]
        public IActionResult Edit (MovieEntry blah)
        {
            maContext.Update(blah);
            maContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
