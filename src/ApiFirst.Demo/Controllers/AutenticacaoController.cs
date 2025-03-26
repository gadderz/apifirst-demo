using ApiFirst.Demo.Models;
using Microsoft.AspNetCore.Authentication.BearerToken;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Demo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {

        [HttpPost]
        [EndpointSummary("Realiza login no sistema")]
        [ProducesResponseType<AccessTokenResponse>(StatusCodes.Status200OK, "application/json")]
        [ProducesResponseType<ErrorResponse>(StatusCodes.Status403Forbidden, "application/json")]
        [EndpointGroupName("v1")]
        public IActionResult Login([FromBody] FazerLogin fazerLogin)
        {
            return Ok();
        }

        [HttpPost]
        [EndpointSummary("O cliente se cadastra no sistema")]
        [ProducesResponseType<Cliente>(StatusCodes.Status200OK, "application/json")]
        [ProducesResponseType<ErrorResponse>(StatusCodes.Status400BadRequest, "application/json")]
        [EndpointGroupName("v1")]
        public IActionResult Cadastro([FromBody] CadastrarCliente cliente)
        {
            return Ok();
        }
    }
}
