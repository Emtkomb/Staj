using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı  giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Password { get; set; }
    }
}
