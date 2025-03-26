using ApiFirst.Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FormaPagamentoController : ControllerBase
    {
        [HttpGet]
        [EndpointSummary("Lista as formas de pagamento disponíveis")]
        [ProducesResponseType<FormaPagamento[]>(StatusCodes.Status200OK)]
        [ProducesResponseType<ErrorResponse>(StatusCodes.Status404NotFound)]
        [EndpointGroupName("v1")]
        public IActionResult ListarFormaPagamento()
        {
            return Ok();
        }
    }
}
