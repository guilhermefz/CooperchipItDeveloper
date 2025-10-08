using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CooperchipItDeveloper.Mvc.Extensions
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(maximumLength:35, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Apelido { get; set; }

        [PersonalData]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(maximumLength: 35, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [Display(Name = "Nome Completo")]
        public string? NomeCompleto { get; set; }

        [PersonalData]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
