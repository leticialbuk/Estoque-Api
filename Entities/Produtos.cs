namespace Estoque.Entities
{
    /// <summary>
    /// Representa um produto na base de dados.
    /// </summary>
    public class Produtos
    {
        /// <summary>
        /// Identificador único do produto.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do produto.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Preço do produto.
        /// </summary>
        public decimal Preco { get; set; }

        /// <summary>
        /// Quantidade do produto.
        /// </summary>
        public int Quantidade { get; set; }
    }
}
