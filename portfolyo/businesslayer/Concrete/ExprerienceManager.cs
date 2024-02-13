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
    public class ExprerienceManager : IExprerience
    {
        IExprerience _exprerience;

        public ExprerienceManager(IExprerience exprerience)
        {
            _exprerience = exprerience;
        }

        public void Delete(exprerience t)
        {
            _exprerience.Delete(t);
        }

        public exprerience GetByID(int id)
        {
            return _exprerience.GetByID(id);
        }

        public List<exprerience> GetList()
        {
            return _exprerience.GetList();
        }

        public void Insert(exprerience t)
        {
            _exprerience.Insert(t);
        }

        public void Update(exprerience t)
        {
            _exprerience.Update(t);
        }
    }
}
