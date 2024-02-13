using businesslayer.Concrete;
using businesslayer.ValidationRules;
using dataaccesslayer.EntityFramework;
using entitylayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolyo.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Slider Düzenleme";
            ViewBag.v2 = "Slider";
            ViewBag.v3 = "Slider Düzenleme";
            var values = aboutManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            ViewBag.v1 = "Slider Düzenleme";
            ViewBag.v2 = "Slider";
            ViewBag.v3 = "Slider Düzenleme";
            AboutValidatior validations = new AboutValidatior();
            ValidationResult results = validations.Validate(about);
            if (results.IsValid)
            {
                aboutManager.TUpdate(about);
                return RedirectToAction("Index", "DefaultController1");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
    }
}
