using dataaccesslayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolyo.ViewComponents.Dashboard
{
    public class FeatureStatistic : ViewComponent
    {
        context c = new context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.skills.Count();
            ViewBag.v2 = c.messages.Where(x=>x.Status==false).Count();
            ViewBag.v3 = c.messages.Where(x => x.Status == true).Count();
            ViewBag.v4 = c.expreriences.Count();
            return View();
        }
    }
}