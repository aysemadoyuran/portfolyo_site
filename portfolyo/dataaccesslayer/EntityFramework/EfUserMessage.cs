using dataaccesslayer.Abstract;
using dataaccesslayer.Concrete;
using dataaccesslayer.Repository;
using entitylayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataaccesslayer.EntityFramework
{
    public class EfUserMessage : GenericRepository<usermessage>, IUserMessageDal
    {
        public List<usermessage> GetUsermessagesWithUser()
        {
           using(var c= new context())
            {
                return c.usermessages.Include(x => x.user).ToList();
            }
        }
    }
}
