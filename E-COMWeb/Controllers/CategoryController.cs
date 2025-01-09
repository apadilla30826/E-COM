using Microsoft.AspNetCore.Mvc;

namespace E_COMWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
