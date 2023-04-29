using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_intro.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int[] nums = { 1, 2, 4, 5, 6, 7, 8 };
            return View(nums);
        }
    }
}
