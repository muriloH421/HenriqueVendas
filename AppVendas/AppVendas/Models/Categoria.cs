using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }
        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "O campo Categoria é obrigatório!")]
        [StringLength(100, ErrorMessage = "O campo Categoria deve ter no máximo 100 caracteres!")]
        public string CategoriaNome { get; set; }
        public IEnumerable<Produto>? Produtos { get; set; }
    }
}
