using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.ToDoDto
{
    public class ToDoAddDto
    {


        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen ToDo adresinizi giriniz")]
        public string Todo { get; set; }
        
    }
}
