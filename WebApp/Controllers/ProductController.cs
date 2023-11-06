using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Admin;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {

        public ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var result = productManager.GetAll();
            IEnumerable<Product> products = result.Data;
            return View(products);
        }
        public ActionResult Create(Product product)
        {
            var result = productManager.Add(product);
            if (result.Success)
            {
                return View(product);
            }
            return BadRequest(result);
        }
        public ActionResult Delete(int id)
        {
            var result = productManager.GetById(id);

            if (result.Success)
            {
                var product = result.Data;
                if (product != null)
                {
                    productManager.Remove(product);
                    return RedirectToAction("Index");
                }
                else
                {

                    ModelState.AddModelError("", "Silinmek istenen özellik bulunamadı.");
                }
            }
            else
            {

                ModelState.AddModelError("", "Özellik alınamadı: " + result.Message);
            }

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.value1 = "Yetenek Güncelleme";
            ViewBag.value2 = "Yetenek";
            ViewBag.value3 = "Yetenek Güncelleme";

            var result = productManager.GetById(id);

            if (result.Success)
            {
                var product = result.Data;
                return View(product);
            }
            else
            {

                return View("ErrorView");
            }
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {

            productManager.Update(product);
            return RedirectToAction("Index");


        }
    }
}
