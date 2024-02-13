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
    public class ServiceManager : IService
    {
        IService _service;

        public ServiceManager(IService service)
        {
            _service = service;
        }

        public void Delete(service t)
        {
            _service.Delete(t);
        }

        public service GetByID(int id)
        {
            return _service.GetByID(id);
        }

        public List<service> GetList()
        {
            return _service.GetList();
        }

        public void Insert(service t)
        {
            _service.Insert(t);
        }

        public void Update(service t)
        {
            _service.Update(t);
        }
    }
}
