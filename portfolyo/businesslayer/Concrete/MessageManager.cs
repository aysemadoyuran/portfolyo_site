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
    public class MessageManager : IMessage
    {
        IMessage _message;

        public MessageManager(IMessage message)
        {
            _message = message;
        }

        public void Delete(message t)
        {
            _message.Delete(t);
        }

        public message GetByID(int id)
        {
            return _message.GetByID(id);
        }

        public List<message> GetList()
        {
            return _message.GetList();
        }

        public void Insert(message t)
        {
            _message.Insert(t);
        }

        public void Update(message t)
        {
            _message.Update(t);
        }
    }
}
