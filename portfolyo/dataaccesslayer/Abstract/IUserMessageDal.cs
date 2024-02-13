﻿using entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataaccesslayer.Abstract
{
    public interface IUserMessageDal: IGenericDal<usermessage>
    {
        public List<usermessage> GetUsermessagesWithUser();
    }
}
 