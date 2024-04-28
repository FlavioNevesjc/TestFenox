using Microsoft.AspNetCore.Mvc;
using TestFenox.Models;

namespace TestFenox.Controllers
{
    public class FuelController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
