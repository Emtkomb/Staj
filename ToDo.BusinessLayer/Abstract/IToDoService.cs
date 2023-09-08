using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.EntityLayer.Concrete;

namespace ToDo.BusinessLayer.Abstract
{
    public interface IToDoService:IGenericService<todo>
    {
    }
}
