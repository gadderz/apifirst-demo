using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Demo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InventarioController : ControllerBase
    {
        [HttpPost]
        [EndpointGroupName("v1")]
        [EndpointSummary("Adiciona um novo produto a um inventario")]
        public IActionResult AdicionarProduto()
        {
            return Ok();
        }

        [HttpPut]
        [EndpointGroupName("v1")]
        [EndpointSummary("Atualiza um item que faz parte de um inventario")]
        public IActionResult AtualizarInventario()
        {
            return Ok();
        }

        [HttpGet]
        [EndpointGroupName("v1")]
        [EndpointSummary("Consulta os itens de um inventario")]
        public IActionResult ConsultarInventario()
        {
            return Ok();
        }

        [HttpPost]
        [EndpointGroupName("v1")]
        [EndpointSummary("Cria uma reserva de um item de um inventario após iniciar o processo de checkout")]
        public IActionResult ReservarInventario()
        {
            return Ok();
        }

        [HttpPost]
        [EndpointGroupName("v1")]
        [EndpointSummary("Libera a reserva dos itens de um cliente")]
        public IActionResult LiberarReserva()
        {
            return Ok();
        }
    }
}
