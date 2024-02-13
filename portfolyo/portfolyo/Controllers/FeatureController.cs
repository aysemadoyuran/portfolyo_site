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
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeature());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Slider Düzenleme";
            ViewBag.v2 = "Slider";
            ViewBag.v3 = "Slider Düzenleme";
            var values = featureManager.GetByID(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            ViewBag.v1 = "Slider Düzenleme";
            ViewBag.v2 = "Slider";
            ViewBag.v3 = "Slider Düzenleme";
            FeatureValidatior validations = new FeatureValidatior();
            ValidationResult results = validations.Validate(feature);
            if(results.IsValid)
            {
                featureManager.Update(feature);
                return RedirectToAction("Index","DefaultController1");
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
