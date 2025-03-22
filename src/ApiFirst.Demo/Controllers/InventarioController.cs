using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Demo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InventarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult AdicionarProduto()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult AtualizarInventario()
        {
            return Ok();
        }
        [HttpGet]
        public IActionResult ConsultarInventario()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult ReservarInventario()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult LiberarReserva()
        {
            return Ok();
        }
    }
}
