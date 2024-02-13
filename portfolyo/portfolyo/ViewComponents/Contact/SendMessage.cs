using businesslayer.Concrete;
using dataaccesslayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using businesslayer.Abstract;

namespace portfolyo.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessage());
        public IViewComponentResult Invoke()
        {
            return View();
        }


    }
}    

    


