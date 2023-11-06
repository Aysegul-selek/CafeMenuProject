using CafeMenuProject.Business.Concrete;
using CafeMenuProject.Entities.Admin;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApp.Controllers
{
    public class ProductPropertyController : Controller
    {
        public ProductPropertyManager productPropertyManager = new ProductPropertyManager(new EfProductPropertyDal());
        public IActionResult Index()
        {
            var result = productPropertyManager.GetAll();
            IEnumerable<ProductProperty> properties = result.Data;
            return View(properties);
        }
        public ActionResult Create(ProductProperty productProperty)
        {
            var result = productPropertyManager.Add(productProperty);
            if (result.Success)
            {
                return View(productProperty);
            }
            return BadRequest(result);
        }
        public ActionResult Delete(int id)
        {
            var result = productPropertyManager.GetById(id);

            if (result.Success)
            {
                var productProperty = result.Data;
                if (productProperty != null)
                {
                    productPropertyManager.Remove(productProperty);
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

            var result = productPropertyManager.GetById(id);

            if (result.Success)
            {
                var productProperty = result.Data;
                return View(productProperty);
            }
            else
            {

                return View("ErrorView");
            }
        }
        [HttpPost]
        public IActionResult Update(ProductProperty p)
        {

            productPropertyManager.Update(p);
            return RedirectToAction("Index");


        }
    }
}
