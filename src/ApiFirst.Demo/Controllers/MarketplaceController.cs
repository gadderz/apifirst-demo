using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Demo.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class MarketplaceController : ControllerBase
{
    [HttpPost]
    [EndpointGroupName("v2")]
    [EndpointSummary("Sincroniza os produtos de uma loja terceira com o marketplace")]
    public IActionResult SincronizarProdutos()
    {
        return Ok();
    }

    [HttpPost]
    [EndpointGroupName("v2")]
    [EndpointSummary("Sincroniza o estoque de uma loja terceira com o marketplace")]
    public IActionResult SincronizarEstoque()
    {
        return Ok();
    }
}
