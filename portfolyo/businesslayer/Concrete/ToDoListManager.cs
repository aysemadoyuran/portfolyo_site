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
    public class ToDoListManager : IToDoListService
    {
        IToDoList _toDoListDal;

        public ToDoListManager(IToDoList toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public void TAdd(todolist t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(todolist t)
        {
            throw new NotImplementedException();
        }

        public todolist TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<todolist> TGetList()
        {
            return _toDoListDal.GetList();
        }

        public void TUpdate(todolist t)
        {
            throw new NotImplementedException();
        }
    }
}
