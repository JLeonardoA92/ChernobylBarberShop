using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ChernobylBarberShop.Core;

namespace ChernobylBarberShop.Controllers
{
    public class RoleController : Controller
    {
        [Authorize(Policy = "EmployeeOnly")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policy = Constants.Policies.RequireAdmin)]
        public IActionResult Manager()
        {
            return View();
        }

        //[Authorize(Policy = "RequireAdmin")]
        [Authorize(Roles = $"{Constants.Roles.Administrator},{Constants.Roles.Manager}")]
        public IActionResult Admin()
        {
            return View();
        }
    }
}
