using Microsoft.AspNetCore.Mvc;

using FutureValue.Models;

namespace FutureValue.Controllers {

    public class HomeController : Controller {

        public IActionResult Index() {
            ViewBag.Name = "Mary"; // ViewBag is a dictionary to store data and the data
            ViewBag.FV = 99999.99;
            return View();
        }

        [HttpPost] // Correlates to the Index.cshtml with the post
        public IActionResult Index(FutureValueModel model) {
            ViewBag.FV = model.CalculateFutureValue();
            return View(model);
        }
    }
}
