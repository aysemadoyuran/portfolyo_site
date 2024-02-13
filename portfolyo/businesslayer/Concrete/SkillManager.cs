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
    public class SkillManager : ISkillDal
    {
        ISkillDal _skilldal;

        public SkillManager(ISkillDal skilldal)
        {
            _skilldal = skilldal;
        }

        public void Delete(skill t)
        {
            _skilldal.Delete(t);
        }

        public skill GetByID(int id)
        {
            return _skilldal.GetByID(id);
        }

        public List<skill> GetList()
        {
            return _skilldal.GetList();
        }

        public void Insert(skill t)
        {
            _skilldal.Insert(t);
        }

        public void Update(skill t)
        {
            _skilldal.Update(t);
        }
    }
}
