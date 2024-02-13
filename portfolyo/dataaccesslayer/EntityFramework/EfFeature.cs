using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataaccesslayer.Abstract;
using dataaccesslayer.Repository;
using entitylayer.Concrete;

namespace dataaccesslayer.EntityFramework
{
    public class EfFeature:GenericRepository<Feature>,IFeature
    {
    }
}
