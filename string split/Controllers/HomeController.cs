using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using string_split.Models;
using System.Diagnostics;

namespace string_split.Controllers
{
    public class HomeController : Controller
    {
        List<SelectListItem> primeData = new List<SelectListItem>()
        {
            new SelectListItem{Text="One | Two | Three",Value="One | Two | Three"},
            new SelectListItem{Text="1 | 2 | 3",Value="1 | 2 | 3"},
            new SelectListItem{Text="Male | Jr.Developer | Chennai",Value="Male | Jr.Developer | Chennai"}
        };

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.PrimData = primeData;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Entities demoData)
        {
            ViewBag.PrimData = primeData;
            string One = demoData.dataOne;
            string Two = demoData.dataTwo;
            string Three = demoData.dataThree;
            return View("DisplayView",demoData);
        }
    }
}