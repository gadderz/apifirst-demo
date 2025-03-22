using ApiFirst.Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        public static List<Produto> p = new List<Produto>() {
            new Produto() {
                Nome = "Iphone"
            }
        };

        [HttpGet("ListarProdutos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [EndpointSummary("Lista os produtos disponíveis para compra.")]
        public IActionResult ListarProdutos([FromQuery] ListarProdutos listarProdutos)
        {
            if (string.IsNullOrEmpty(listarProdutos.Busca) is false)
            {
                return Ok(p.Where(p => p.Nome.Contains(listarProdutos.Busca)));
            }
            
            return Ok(p);
        }

        [HttpPost]
        public IActionResult AdicionarProduto([FromBody] Produto produto)
        {
            return Ok();
        }

        [HttpPut("{IdProduto}")]
        public IActionResult AtualizarProduto(int IdProduto, [FromBody] Produto produto)
        {
            return Ok();
        }

        [HttpDelete("{IdProduto}")]
        public IActionResult RemoverProduto(int IdProduto)
        {
            return Ok();
        }


    }
}
