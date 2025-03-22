using System;
using ApiFirst.Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Demo.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class CarrinhoController : ControllerBase
{

    [HttpPost]
    public IActionResult AdicionarItem([FromBody] AdicionarItemCarrinho itemCarrinho)
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult Visualizar([FromQuery] string IdSessao)
    {
        return Ok();
    }

    [HttpPut("{IdSessao}")]
    public IActionResult AtualizarQuantidade(string IdSessao, [FromBody] AtualizarQuantidadeCarrinho atualizarQuantidade)
    {
        return Ok();
    }

    [HttpDelete("IdProduto")]
    public IActionResult RemoverItem(int IdProduto)
    {
        return Ok();
    }

    [HttpDelete]
    public IActionResult Limpar([FromQuery] string IdSessao)
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult Estoque([FromQuery] string IdSessao)
    {
        return Ok();
    }
}
