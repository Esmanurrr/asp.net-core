using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAspNetCoreApp.Web.Models
{
    public class ProductRepository
    {

        private static List<Product> _products = new List<Product>()
        {
            new() { Id = 1, Name = "Kalem", Price = 100, Stock = 200 },
            new() { Id = 2, Name = "Silgi", Price = 200, Stock = 300 },
            new() { Id = 3, Name = "Defter", Price = 300, Stock = 400 },
            new() { Id = 4, Name = "Kitap", Price = 400, Stock = 500 }
        };
        public List<Product> GetAll() => _products;//return _products anlamında lambda ifadedir. ve bu metod ürünleri listeler
        public void Add(Product newProduct) => _products.Add(newProduct);
        public void Remove(int id)
        {
            var hasProduct = _products.FirstOrDefault(x => x.Id == id);  //buradaki x _products'a karşılık geliyor
            if (hasProduct == null)
            {
                throw new Exception($"Bu id({id})'ye karşılık ürün bulunmamaktadır.");
            }

            _products.Remove(hasProduct);

        }

        public void Update(Product updateProduct)
        {
            var hasProduct = _products.FirstOrDefault(x => x.Id == updateProduct.Id); //var mı diye kontrol ediyoruz.
            if (hasProduct == null)
            {
                throw new Exception($"Bu id({updateProduct.Id})'ye karşılık ürün bulunmamaktadır.");
            }

            hasProduct.Name = updateProduct.Name;
            hasProduct.Price = updateProduct.Price;
            hasProduct.Stock = updateProduct.Stock;

            var index = _products.FindIndex(x => x.Id == updateProduct.Id);//aynı id'yi bulacak.
            _products[index] = hasProduct;

        }

    }
}
