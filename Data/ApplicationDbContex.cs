using Microsoft.EntityFrameworkCore;
using PaginacaoAspNetMVC.Models;
using System.Collections.Generic;

namespace PaginacaoAspNetMVC.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }

}
