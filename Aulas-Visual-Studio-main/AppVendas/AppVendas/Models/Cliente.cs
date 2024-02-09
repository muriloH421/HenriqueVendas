using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres!")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "O campo E-mail é obrigatório!")]
        [EmailAddress(ErrorMessage = "Formato do e-mail inválido!")]
        [StringLength(100, ErrorMessage = "O campo E-mail deve ter no máximo 100 caracteres!")]

        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório!")]
        public DateOnly DataNascimento { get; set; }

        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "O campo Data de Cadastro é obrigatório!")]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
