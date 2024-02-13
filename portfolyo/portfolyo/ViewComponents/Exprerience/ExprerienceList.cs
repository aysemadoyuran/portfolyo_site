using businesslayer.Concrete;
using dataaccesslayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolyo.ViewComponents.Exprerience
{
    public class ExprerienceList : ViewComponent
    {
        ExprerienceManager exprerienceManager = new ExprerienceManager(new EfExprerience());
        public IViewComponentResult Invoke()
        {
            var values = exprerienceManager.GetList();
            return View(values);
        }

    }
}
