using Microsoft.AspNetCore.Mvc;

namespace ChernobylBarberShop.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
