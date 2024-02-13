using businesslayer.Abstract;
using dataaccesslayer.Abstract;
using entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayer.Concrete
{
    public class UserMessageManager:IUserMessageService
    {
        IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public List<usermessage> GetUsermessagesWithUserService()
        {
             return _userMessageDal.GetUsermessagesWithUser();
        }

        public void TAdd(usermessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(usermessage t)
        {
            throw new NotImplementedException();
        }

        public usermessage TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<usermessage> TGetList()
        {
            return _userMessageDal.GetList();
        }

        public void TUpdate(usermessage t)
        {
            throw new NotImplementedException();
        }
    }
}
