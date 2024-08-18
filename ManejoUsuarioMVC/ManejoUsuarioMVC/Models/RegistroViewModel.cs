using System.ComponentModel.DataAnnotations;

namespace ManejoUsuarioMVC.Models
{
    public class RegistroViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
