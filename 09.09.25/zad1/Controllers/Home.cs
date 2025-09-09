using Microsoft.AspNetCore.Mvc;

namespace zad1.Controllers
{
    public class Home : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            string info = "to jest info z akcji about";
            ViewBag.info = info;
            string info2 = "to jest info2";
            return View("OtherAbout", info2);
        }

    }
}
