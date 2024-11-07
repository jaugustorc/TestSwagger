using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private static readonly List<Produto> Produtos = new List<Produto>
            {
                new Produto(1, "TV", 1000.00M),
                new Produto(2, "Geladeira", 1000.00M),
                new Produto(3, "Fogão", 1000.00M),
                new Produto(4, "Micro-ondas", 1000.00M)
            };

        /// <summary>
        /// Retorna todos os produtos disponíveis.
        /// </summary>
        /// <remarks>
        /// Exemplo de retorno:
        /// 
        ///     GET /api/produtos
        ///     {
        ///        "id": 1,
        ///        "nome": "Produto A",
        ///        "preco": 100.00
        ///     }
        /// </remarks>
        /// <response code="200">Retorna a lista de produtos</response>
        /// <response code="400">Erro ao tentar encontrar produtos</response>
        /// <response code="404">Nenhum produto encontrado</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<Produto>> ObterProdutos()
        {
            // Implementação do método
            try
            {
                if (Produtos.Count > 0)
                    return Ok(Produtos);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
