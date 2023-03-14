using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class Product2
    {
        public int Id { get; set; }
        public string name { get; set; }
    }


    public class OrnekController : Controller
    {
        public IActionResult Index()
        {

            var productList = new List<Product2>
            {
                new(){Id= 1, name="kalem"},
                new(){Id= 2, name="defter"},
                new(){Id=3, name="silgi"}
            };


            return View(productList);
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
