using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Admin;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApp.Controllers
{
    public class CategoryController : Controller
    {
        public CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var result = categoryManager.GetAll();
            IEnumerable<Category> categories = result.Data;
            return View(categories);
        }
        public ActionResult Create(Category category)
        {
            var result = categoryManager.Add(category);
            if (result.Success)
            {
                return View(category);
            }
            return BadRequest(result);
        }
        public ActionResult Delete(int id)
        {
            var result = categoryManager.GetById(id);

            if (result.Success)
            {
                var category = result.Data;
                if (category != null)
                {
                    categoryManager.Remove(category);
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

            var result = categoryManager.GetById(id);

            if (result.Success)
            {
                var category = result.Data;
                return View(category);
            }
            else
            {

                return View("ErrorView");
            }
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {

            categoryManager.Update(category);
            return RedirectToAction("Index");


        }

    }
}
