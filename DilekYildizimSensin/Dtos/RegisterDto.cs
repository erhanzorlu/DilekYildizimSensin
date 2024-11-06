using DilekYildizimSensin.Models.Enums;
using System.ComponentModel.DataAnnotations;
namespace DilekYildizimSensin.Dtos
{

    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        public string Password { get; set; }

        [Required, Compare("Password", ErrorMessage = "Şifreler eşleşmiyor.")]
        public string ConfirmPassword { get; set; } // Şifre tekrarı

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public GenderEnum Gender { get; set; }

        [Required, Range(1, 120, ErrorMessage = "Yaş 1 ile 120 arasında olmalıdır.")]
        public int Age { get; set; }
        public string? ImageUrl { get; set; }
    }


}
