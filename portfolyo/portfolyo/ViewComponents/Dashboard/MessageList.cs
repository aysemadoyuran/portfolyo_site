using businesslayer.Concrete;
using dataaccesslayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolyo.ViewComponents.Dashboard
{

    public class MessageList: ViewComponent
    {
        UserMessageManager userMessageManager= new UserMessageManager(new EfUserMessage());
        public IViewComponentResult Invoke()
        {
            var values = userMessageManager.GetUsermessagesWithUserService();
            return View(values);
        }
    }
}
