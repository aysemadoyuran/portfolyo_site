using businesslayer.Concrete;
using dataaccesslayer.EntityFramework;
using entitylayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolyo.Controllers
{
    public class ExprerienceController : Controller
    {
        ExprerienceManager exprerienceManager = new ExprerienceManager(new EfExprerience());
        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyim Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Listesi";
            var values = exprerienceManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExprerience()
        {
            ViewBag.v1 = "Deneyim Ekleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Ekleme";
            return View();

        }
        [HttpPost]
        public IActionResult AddExprerience(exprerience pr1)
        {
            exprerienceManager.Insert(pr1);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExprerience(int id)
        {
            var values = exprerienceManager.GetByID(id);
            exprerienceManager.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExprerience(int id)
        {
            ViewBag.v1 = "Deneyim Güncelleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Güncelleme";
            var values = exprerienceManager.GetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditExprerience(exprerience Exprerience)
        {
            exprerienceManager.Update(Exprerience);
            return RedirectToAction("Index");
        }
    }
}
