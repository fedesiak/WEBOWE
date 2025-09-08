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

    }
}
