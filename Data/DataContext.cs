using Estoque.Entities;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Data
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// Construtor do contexto do banco de dados.
        /// </summary>
        /// <param name="options">Opções de configuração do contexto.</param>
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        /// <summary>
        /// DbSet que representa a tabela de produtos no banco de dados.
        /// </summary>
        public DbSet<Produtos> Produtos { get; set; }
    }
}
