using Microsoft.AspNetCore.Mvc;

namespace AnimalCateringProject.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult OrderPageView()
        {
            return View("~/Views/OrderDishView.cshtml");
        }

        public IActionResult AdminPageView()
        {
            return View("~/Views/AdminPageView.cshtml");
        }
    }
}