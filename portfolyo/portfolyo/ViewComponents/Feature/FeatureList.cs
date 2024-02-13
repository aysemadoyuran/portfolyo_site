using businesslayer.Concrete;
using dataaccesslayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolyo.ViewComponents.Feature
{
    public class FeatureList: ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeature());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.GetList();
            return View(values);
        }

    }
}
