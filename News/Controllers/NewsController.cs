using Microsoft.AspNetCore.Mvc;
using News.Models;

namespace News.Controllers
{
    public class NewsController : Controller
    {
        private static List<Newses> news = new List<Newses>();

        public IActionResult index()
        {
            return View(news);
        }
        [HttpGet]
        public IActionResult Creat()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Creat(Newses model)
        {
            news.Add(model);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var Newsee = news.FirstOrDefault(w => w.Id == id);
            news.Remove(Newsee);
            return RedirectToAction("Index");

        }
        public IActionResult Detail(int id)
        {
            var Newsee = news.FirstOrDefault(x => x.Id == id);
            return View(Newsee);
        }

    }
}
