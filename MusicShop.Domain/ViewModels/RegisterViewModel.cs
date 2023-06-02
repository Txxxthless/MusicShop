<<<<<<< HEAD
﻿
using System.ComponentModel.DataAnnotations;

namespace MusicShop.Domain.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Enter username!")]
        [MinLength(3, ErrorMessage = "Min username length is 3!")]
        [MaxLength(30, ErrorMessage = "Max usermane length is 30!")]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter password!")]
        [MinLength(5, ErrorMessage = "Min password length is 5!")]
        [MaxLength(30, ErrorMessage = "Max password length is 30!")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm your password!")]
        [Compare("Password", ErrorMessage = "The passwords don't match!")]
        public string ConfirmPassword { get; set; }
    }
}
=======
﻿
using System.ComponentModel.DataAnnotations;

namespace MusicShop.Domain.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Enter username!")]
        [MinLength(3, ErrorMessage = "Min username length is 3!")]
        [MaxLength(30, ErrorMessage = "Max usermane length is 30!")]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter password!")]
        [MinLength(5, ErrorMessage = "Min password length is 5!")]
        [MaxLength(30, ErrorMessage = "Max password length is 30!")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm your password!")]
        [Compare("Password", ErrorMessage = "The passwords don't match!")]
        public string ConfirmPassword { get; set; }
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
