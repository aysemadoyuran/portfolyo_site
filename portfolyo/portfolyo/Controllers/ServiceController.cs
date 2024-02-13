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
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfService());
        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmetler Listesi";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmetler Listesi";
            var values = serviceManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.v1 = "Hizmetler Listesi";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmetler Listesi";
            return View();

        }
        [HttpPost]
        public IActionResult AddService(service Service)
        {
            ViewBag.v1 = "Hizmetler Listesi";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmetler Listesi";
            serviceManager.Insert(Service);
            return RedirectToAction("Index");


        }
        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.GetByID(id);
            serviceManager.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.v1 = "Hizmetler Listesi";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmetler Listesi";
            var values = serviceManager.GetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(service Service)
        {
            ViewBag.v1 = "Hizmetler Listesi";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmetler Listesi";
            serviceManager.Update(Service);
            return RedirectToAction("Index");


        }
    }
}
