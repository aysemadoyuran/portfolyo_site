using entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayer.Abstract
{
    public interface IUserMessageService : IGenericService<usermessage>
    {
        List<usermessage> GetUsermessagesWithUserService();
    }
}
