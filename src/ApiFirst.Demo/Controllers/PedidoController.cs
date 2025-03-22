using ApiFirst.Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Demo.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class PedidoController : ControllerBase
{
    [HttpPost]
    public IActionResult IniciarCheckout([FromBody] Pedido pedido)
    {
        return Ok();
    }
    
    [HttpPost]
    public IActionResult AplicarCupom([FromBody] Pedido pedido)
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult CalcularFrete([FromBody] Pedido pedido)
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult ConfirmarPagamento([FromBody] Pedido pedido)
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult Resumo([FromBody] Pedido pedido)
    {
        return Ok();
    }

    /// <summary>
    /// Realiza pedido
    /// </summary>
    /// <param name="pedido"></param>
    /// <returns></returns>
    [HttpPost]
    public IActionResult FazerPedido([FromBody] Pedido pedido)
    {
        return Ok();
    }
}
