using System.ComponentModel.DataAnnotations.Schema;

namespace PaginacaoAspNetMVC.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Preco { get; set; }

        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

    }
}
