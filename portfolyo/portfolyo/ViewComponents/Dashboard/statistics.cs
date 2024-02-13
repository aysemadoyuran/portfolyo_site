using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolyo.ViewComponents.Dashboard
{
    public class statistics: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
