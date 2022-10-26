using Microsoft.AspNetCore.Mvc;

namespace MassConservation.Controllers
{
    public class BillSearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
