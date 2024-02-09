using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        [Display(Name = "Produto")]
        public string ProdutoNome { get; set; }
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        [Display(Name = "Categoria")]
        public Guid ? CategoriaId { get; set; }
        public Categoria ? Categoria { get; set; }
    }
}
