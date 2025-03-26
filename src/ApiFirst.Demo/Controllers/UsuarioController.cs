using ApiFirst.Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        [EndpointGroupName("v1")]
        [EndpointSummary("Adiciona um endereço de entrega de um cliente")]
        public IActionResult AdicionarEndereco([FromBody] Endereco endereco)
        {
            return Ok();
        }

        [HttpPut]
        [EndpointGroupName("v1")]
        [EndpointSummary("Atualiza um endereço de entrega")]
        public IActionResult AtualizarEndereco()
        {
            return Ok();
        }

        [HttpPost]
        [EndpointGroupName("v1")]
        [EndpointSummary("Adiciona uma forma de pagamento e vincula a conta do cliente")]
        public IActionResult AdicionarFormaPagamento()
        {
            return Ok();
        }
        [HttpDelete]
        [EndpointGroupName("v1")]
        [EndpointSummary("Remove uma forma de pagamento salva")]
        public IActionResult RemoverFormaPagamento()
        {
            return Ok();
        }
    }
}
