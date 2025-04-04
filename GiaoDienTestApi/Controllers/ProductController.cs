using Microsoft.AspNetCore.Mvc;
namespace GiaoDienTestApi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            ViewData["ProductId"] = id;
            return View();
        }

        public IActionResult Detail(int id)
        {
            ViewData["ProductId"] = id;
            return View();
        }

        public IActionResult Delete(int id)
        {
            ViewData["ProductId"] = id;
            return View();
        }
    }
}