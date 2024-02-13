using dataaccesslayer.Abstract;
using dataaccesslayer.Repository;
using entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataaccesslayer.EntityFramework
{
    public class EfToDoListDal:GenericRepository<todolist>,IToDoList
    {
    }
}
