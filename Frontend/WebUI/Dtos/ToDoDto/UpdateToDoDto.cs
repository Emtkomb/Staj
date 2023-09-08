using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.ToDoDto
{
    public class UpdateToDoDto
    {
        [Required(ErrorMessage = "Lütfen Id giriniz")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen ToDo giriniz")]
        public string Todo { get; set; }

       
    }
}
