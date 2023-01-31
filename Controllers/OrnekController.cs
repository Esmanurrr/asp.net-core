using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class Product
    {
        public int deger { get; set; }
        public string isim { get; set; }
        public int yas { get; set; }
    }


    public class OrnekController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.name = "ASP .Net Core";
            ViewData["age"] = 30;

            ViewData["isimler"] = new List<string>() {"serkan", "esmanur" };

            ViewBag.person = new {Id = 1, name = "süleyman", age = 25 };
          

            ViewBag.name = "esmanur";

            TempData["surname"] = "mazlum";

            return View();
        }

        public IActionResult Index2()
        {
            return View();

        }
        public IActionResult Index3()
        {
            
            return RedirectToAction("Index");
        }

        public IActionResult ParameterView(int id)
        {
            return RedirectToAction("JsonResult", "Ornek", new {id=id});
        }

        public IActionResult JsonResult(int id)
        {
            return Json(new { Id = id});
        }

        public IActionResult ContentResult()
        {
            return Content("Content Result");
        }


        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
    }
}
