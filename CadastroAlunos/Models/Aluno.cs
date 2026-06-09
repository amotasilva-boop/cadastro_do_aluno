using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroAlunos.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O RA é obrigatório")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "O RA deve ter entre 5 e 20 caracteres")]
        [Display(Name = "RA (Registro Acadêmico)")]
        public string RA { get; set; }

        [Required(ErrorMessage = "O curso é obrigatório")]
        [Display(Name = "Curso")]
        public string Curso { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
