using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using businesslayer.Abstract;
using dataaccesslayer.Abstract;
using entitylayer.Concrete;

namespace businesslayer.Concrete
{
    public class FeatureManager : IFeature
    {
        IFeature _feature;

        public FeatureManager(IFeature feature)
        {
            _feature = feature;
        }

        public void Delete(Feature t)
        {
            _feature.Delete(t);
        }

        public Feature GetByID(int id)
        {
            return _feature.GetByID(id);
        }

        public List<Feature> GetList()
        {
            return _feature.GetList();
        }

        public void Insert(Feature t)
        {
            _feature.Insert(t);
        }

        public void Update(Feature t)
        {
            _feature.Update(t);
        }
    }
}
