using Microsoft.AspNetCore.Mvc;

namespace ProductsProjectAPI.Controllers
{
    public class UserAuth : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login() 
        {
            return Ok();
        }

        public IActionResult Register() 
        {
            return Ok();
        }
    }
}
