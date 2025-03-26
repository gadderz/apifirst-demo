using ApiFirst.Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Demo.Controllers
{
    [Route("api/[controller]/[action]")]
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
        [EndpointGroupName("v1")]
        public IActionResult ListarProdutos([FromQuery] ListarProdutos listarProdutos)
        {
            if (string.IsNullOrEmpty(listarProdutos.Busca) is false)
            {
                return Ok(p.Where(p => p.Nome.Contains(listarProdutos.Busca)));
            }
            
            return Ok(p);
        }

        [HttpPost]
        [EndpointGroupName("v1")]
        [EndpointSummary("Cria um novo produto")]
        public IActionResult AdicionarProduto([FromBody] Produto produto)
        {
            return Ok();
        }

        [HttpPut("{IdProduto}")]
        [EndpointGroupName("v1")]
        [EndpointSummary("Atualiza as informações do produto")]
        public IActionResult AtualizarProduto(int IdProduto, [FromBody] Produto produto)
        {
            return Ok();
        }

        [HttpDelete("{IdProduto}")]
        [EndpointGroupName("v1")]
        [EndpointSummary("Remove um produto caso")]
        public IActionResult RemoverProduto([FromRoute]int IdProduto)
        {
            return Ok();
        }


    }
}
