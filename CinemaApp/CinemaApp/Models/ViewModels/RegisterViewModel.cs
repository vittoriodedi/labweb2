using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Il nome utente è obbligatorio")]
        [StringLength(50, MinimumLength = 7, ErrorMessage = "Il nome utente deve essere compreso tra 7 e 50 caratteri")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "La password è obbligatoria")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "La password deve essere di almeno 6 caratteri")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Conferma la password")]
        [Compare("Password", ErrorMessage = "Le password non corrispondono")]
        public string ConfirmPassword { get; set; }
        
        [Required(ErrorMessage = "L'email è obbligatoria")]
        [EmailAddress(ErrorMessage = "Formato email non valido")]
        public string Email { get; set; }
    }
}