using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.DataAccessLayer.Abstract;
using ToDo.DataAccessLayer.Concrete;
using ToDo.DataAccessLayer.Repositories;
using ToDo.EntityLayer.Concrete;

namespace ToDo.DataAccessLayer.EntityFramework
{
    public class EfToDoDal:GenericRepository<todo>,IToDoDal
    {
        public EfToDoDal(Context context) : base(context) 
        {
             
        }
    }
}
