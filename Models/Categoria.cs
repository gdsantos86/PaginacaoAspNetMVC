﻿namespace PaginacaoAspNetMVC.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string Nome { get; set; }

        public ICollection<Produto>? Produto { get; set; }
    }

}
