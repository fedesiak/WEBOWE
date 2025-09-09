using Microsoft.AspNetCore.Mvc;

namespace cw1.Controllers
{
    public class ContactsController : Controller
    {
        // GET: ContactsController
        public ActionResult Index()
        {
            List<string> contacts = new List<string>()
            {
                "Alina","Balina","Michał","Roman","Edek"
            };
            return View(contacts);
        }

    }
}
