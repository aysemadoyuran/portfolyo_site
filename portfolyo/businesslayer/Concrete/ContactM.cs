using dataaccesslayer.Abstract;
using entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayer.Concrete
{
    public class ContactM : IContact
    {
        IContact _contact;

        public ContactM(IContact contact)
        {
            _contact = contact;
        }

        public void Delete(contact t)
        {
            throw new NotImplementedException();
        }

        public contact GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<contact> GetList()
        {
            return _contact.GetList();
        }

        public void Insert(contact t)
        {
            throw new NotImplementedException();
        }

        public void Update(contact t)
        {
            throw new NotImplementedException();
        }
    }
}
