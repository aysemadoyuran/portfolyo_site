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
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavBarPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SendMessage(message p)
        {
            MessageManager messageManager = new MessageManager(new EfMessage());
            p.Date = Convert.ToString(Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            p.Status = true;
            messageManager.Insert(p);
            return PartialView();
            
        }
    }
}
