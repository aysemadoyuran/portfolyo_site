using businesslayer.Concrete;
using dataaccesslayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolyo.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        ContactM contacManager = new ContactM(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = contacManager.GetList();
            return View(values);
        }
    }

}
