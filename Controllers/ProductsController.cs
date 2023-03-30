using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyAspNetCoreApp.Web.Helpers;
using MyAspNetCoreApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class ProductsController : Controller
    {

        private AppDbContext _context;

        private IHelper _helper;//singelton example

        private readonly ProductRepository _productRepository;



        public ProductsController(AppDbContext context)
        {
            _productRepository = new ProductRepository();

            _context = context;



        }

        public IActionResult Index()
        {



            var products = _context.Products.ToList();

            return View(products);
        }

        public IActionResult Remove(int id)
        {

            var product = _context.Products.Find(id);

            _context.Products.Remove(product);

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {

            ViewBag.Expire = new Dictionary<string, int>() {
                { "1 ay", 1},
                { "3 ay", 3},
                { "6 ay", 6},
                { "12 ay", 12}
            };

            ViewBag.ColorSelect = new SelectList( new List<ColorSelectList>()
            {   
                new() {Data="Blue", Value="Blue"},
                new() {Data="Red", Value="Red"},
                new() {Data="Green", Value="Green"},

            },"Value","Data");

            return View();
        }

        [HttpPost]
        public IActionResult Add(Product newProduct)
        {
            
            _context.Products.Add(newProduct);
            _context.SaveChanges();

            TempData["status"] = "Ürün başarıyla eklendi.";


            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = _context.Products.Find(id);

            ViewBag.ExpireValue = product.Expire;
            ViewBag.Expire = new Dictionary<string, int>() {
                { "1 ay", 1},
                { "3 ay", 3},
                { "6 ay", 6},
                { "12 ay", 12}
            };

            ViewBag.ColorSelect = new SelectList(new List<ColorSelectList>()
            {
                new() {Data="Blue", Value="Blue"},
                new() {Data="Red", Value="Red"},
                new() {Data="Green", Value="Green"},

            }, "Value", "Data", product.Color);

            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product updateProduct)
        {

            _context.Products.Update(updateProduct);
            _context.SaveChanges();

            TempData["status"] = "Ürün başarıyla güncellendi.";

            return RedirectToAction("Index");
        }

    }
}
