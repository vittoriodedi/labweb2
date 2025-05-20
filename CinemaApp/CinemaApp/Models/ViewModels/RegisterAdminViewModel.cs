using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models.ViewModels
{
    public class RegisterAdminViewModel
    {
        [Required(ErrorMessage = "L'email è richiesta")]
        [EmailAddress(ErrorMessage = "Formato email non valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Il nome utente è richiesto")]
        [MinLength(3, ErrorMessage = "Il nome utente deve avere almeno 3 caratteri")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "La password è richiesta")]
        [MinLength(6, ErrorMessage = "La password deve avere almeno 6 caratteri")]
        public string Password { get; set; }

        [Required(ErrorMessage = "La conferma della password è richiesta")]
        [Compare("Password", ErrorMessage = "Le password non corrispondono")]
        public string ConfirmPassword { get; set; }
    }
}