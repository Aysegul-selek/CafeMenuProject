using Business.Concrete;
using CafeMenuProject.Business.Concrete;
using CafeMenuProject.Entities.Admin;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApp.Controllers
{
    public class PropertyController : Controller
    {
      public PropertyManager propertyManager=new PropertyManager(new EfPropertyDal());
        public IActionResult Index()
        {
            var result = propertyManager.GetAll(); 
            IEnumerable<Property> properties = result.Data;
            return View(properties);
        }
        public ActionResult Create(Property property)
        {
            var result = propertyManager.Add(property);
            if (result.Success)
            {
                return View(property);
            }
            return BadRequest(result);
        }
        public ActionResult Delete(int id)
        {
            var result = propertyManager.GetById(id);

            if (result.Success)
            {
                var property = result.Data; 
                if (property != null)
                {
                    propertyManager.Remove(property);
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

            var result = propertyManager.GetById(id);

            if (result.Success)
            {
                var property = result.Data; 
                return View(property);
            }
            else
            {
                
                return View("ErrorView");
            }
        }
        [HttpPost]
        public IActionResult Update(Property p)
        {
            
                propertyManager.Update(p);
                return RedirectToAction("Index");
            
          
        }

    }
}
