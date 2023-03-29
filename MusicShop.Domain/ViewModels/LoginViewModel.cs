
using System.ComponentModel.DataAnnotations;

namespace MusicShop.Domain.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Enter username!")]
        [MinLength(3, ErrorMessage = "Min username length is 3!")]
        [MaxLength(30, ErrorMessage = "Max usermane length is 30!")]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter password!")]
        [MinLength(5, ErrorMessage = "Min password length is 5!")]
        [MaxLength(30, ErrorMessage = "Max password length is 5!")]
        public string Password { get; set; }
    }
}
