using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Demo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {

        [HttpPost]
        public IActionResult Login()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Cadastro()
        {
            return Ok();
        }
    }
}
