using Microsoft.AspNetCore.Mvc;
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

        

        public ProductsController(AppDbContext context,IHelper helper)
        {
            _productRepository = new ProductRepository();

            _context = context;

            _helper = helper;   

            //if (!_context.Products.Any())//içinde herhangi bir data yoksa bunları ekle
            //{
            //    _context.Products.Add(new Product() { Name = "Kalem", Price = 100, Stock = 100, Color="Red"});
            //    _context.Products.Add(new Product() { Name = "Silgi", Price = 200, Stock = 200, Color = "Red" });
            //    _context.Products.Add(new Product() { Name = "Defter", Price = 300, Stock = 300, Color = "Red"});//ef core bu dataları ramde tutuyor, bunu veritabanında da görebilmek için aşağıdaki kodu kullanırız.

            //    _context.SaveChanges();
            //}
            

        }

        public IActionResult Index([FromServices]IHelper helper2)
        {
            var text = "Asp.Net";
            var upperText = _helper.Upper(text);

            var status = _helper.Equals(helper2);//helper ve helper2'nin aynı tür olup olmadığını kontrol ediyoruz

            pvar products = _context.Products.ToList();

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

            return View();
        }

        [HttpPost]
        public IActionResult Add(Product newProduct)
        {
            //1. yöntem

            //var name = HttpContext.Request.Form["Name"].ToString();
            //var price = decimal.Parse(HttpContext.Request.Form["Price"].ToString());
            //var stock = int.Parse(HttpContext.Request.Form["Stock"].ToString());
            //var color = HttpContext.Request.Form["Color"].ToString();

            //2. yöntem
            //Product myProduct = new Product() { Name=name, Price=price, Stock=stock, Color=color};
            _context.Products.Add(newProduct);
            _context.SaveChanges();

            TempData["status"] = "Ürün başarıyla eklendi.";


            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = _context.Products.Find(id);  

            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product updateProduct, int productId)
        {
            updateProduct.Id = productId;

            _context.Products.Update(updateProduct);
            _context.SaveChanges();

            TempData["status"] = "Ürün başarıyla güncellendi.";

            return RedirectToAction("Index");
        }

    }
}
