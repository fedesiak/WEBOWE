using Microsoft.AspNetCore.Mvc;

namespace cw1.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index() //akcja ktora zwraca jakis efekt
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
