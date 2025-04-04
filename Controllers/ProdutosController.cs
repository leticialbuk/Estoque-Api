using Estoque.Data;
using Estoque.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly DataContext _context;

        /// <summary>
        /// Construtor do controlador de produtos.
        /// </summary>
        /// <param name="context">Contexto do banco de dados.</param>
        public ProdutosController(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retorna a lista de produtos cadastrados.
        /// </summary>
        /// <returns>Uma lista de produtos.</returns>
        /// <response code="200">Retorna a lista de produtos.</response>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Produtos>), 200)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produtos>>> GetProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

    }
}
