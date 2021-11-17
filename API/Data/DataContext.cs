using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    //Identity
    public class DataContext : DbContext
    {
        //Entity Framework - Code First
        //Construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Lista de propriedades de classes de modelo que vão virar as tabelas no banco
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}