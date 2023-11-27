using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestDotnetMvcWithVs.Models;

namespace TestDotnetMvcWithVs.Controllers
{
    public class MovieController : Controller

    {
        private MyContext _context;
        public MovieController(MyContext context)
        {
            _context = context;
        }
        // GET: MovieController
        public ActionResult Index()
        {

            return View();
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: MovieController/CreateMovie
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateMovie(Movie newMovie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newMovie);
                return RedirectToAction("Index", "Home");
            }
            return View("Create");
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
