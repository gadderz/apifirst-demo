using ApiFirst.Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Demo.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class PedidoController : ControllerBase
{
    [HttpPost]
    [EndpointGroupName("v1")]
    [EndpointSummary("Inicia checkout para processar o pedido")]
    public IActionResult IniciarCheckout([FromBody] Pedido pedido)
    {
        return Ok();
    }
    
    [HttpPost]
    [EndpointGroupName("v1")]
    [EndpointSummary("Aplica cupom de desconto")]
    public IActionResult AplicarCupom([FromBody] Pedido pedido)
    {
        return Ok();
    }

    [HttpGet]
    [EndpointGroupName("v1")]
    [EndpointSummary("Calcula o frete de entrega")]
    public IActionResult CalcularFrete([FromBody] Pedido pedido)
    {
        return Ok();
    }

    [HttpPost]
    [EndpointGroupName("v1")]
    [EndpointSummary("Faz a realização do pagamento")]
    public IActionResult ConfirmarPagamento([FromBody] Pedido pedido)
    {
        return Ok();
    }

    [HttpGet]
    [EndpointGroupName("v1")]
    [EndpointSummary("Retorna um resumo do pedido")]
    public IActionResult Resumo([FromBody] Pedido pedido)
    {
        return Ok();
    }

    [HttpPost]
    [EndpointGroupName("v1")]
    [EndpointSummary("Confirma o pedido")]
    public IActionResult FazerPedido([FromBody] Pedido pedido)
    {
        return Ok();
    }
}
