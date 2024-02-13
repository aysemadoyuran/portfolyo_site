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
    public class Contact : IContact
    {
        IContact _contact;

        public Contact(IContact contact)
        {
            _contact = contact;
        }

        public void Delete(contact t)
        {
            _contact.Delete(t);
        }

        public contact GetByID(int id)
        {
            return _contact.GetByID(id);
        }

        public List<contact> GetList()
        {
            return _contact.GetList();
        }

        public void Insert(contact t)
        {
            _contact.Insert(t);
        }

        public void Update(contact t)
        {
            _contact.Update(t);
        }
    }
}
