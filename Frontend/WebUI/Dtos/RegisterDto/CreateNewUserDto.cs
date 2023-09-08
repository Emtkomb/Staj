using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Lütfen isim  giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soy adınızı giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password", ErrorMessage = "Lütfen şifrelerin eşleştiğinden emin olunuz")]
        public string ConfirmPassword { get; set; }
    }
}
