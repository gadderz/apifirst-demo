using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FormaPagamentoController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListarFormaPagamento()
        {
            return Ok();
        }
    }
}
