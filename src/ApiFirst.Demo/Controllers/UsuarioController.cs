using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult AdicionarEndereco()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult AtualizarEndereco()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AdicionarFormaPagamento()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult RemoverFormaPagamento()
        {
            return Ok();
        }
    }
}
