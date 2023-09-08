using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BusinessLayer.Abstract;
using ToDo.DataAccessLayer.Abstract;
using ToDo.EntityLayer.Concrete;

namespace ToDo.BusinessLayer.Concrete
{
    public class TodoManager : IToDoService
    {
        private readonly IToDoDal _tododal;

        public TodoManager(IToDoDal tododal)
        {
            _tododal = tododal;
        }

        public void TDelete(todo t)
        {
            _tododal.Delete(t);
            
        }

        public todo TGetByID(int id)
        {
            return _tododal.GetByID(id);
        }

        public List<todo> TGetList()
        {
            return _tododal.GetList();
        }

        public void TInsert(todo t)
        {
            _tododal.Insert(t);
        }

        public void TUpdate(todo t)
        {
            _tododal.Update(t);
        }
    }
}
