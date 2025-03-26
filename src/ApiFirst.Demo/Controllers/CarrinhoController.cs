using System;
using ApiFirst.Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFirst.Demo.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class CarrinhoController : ControllerBase
{

    [HttpPost]
    [EndpointSummary("Adiciona um novo item no carrinho")]
    [ProducesResponseType<AdicionarItemCarrinho>(StatusCodes.Status201Created, "application/json")]
    [ProducesResponseType<ErrorResponse>(StatusCodes.Status400BadRequest, "application/json")]
    [EndpointGroupName("v1")]
    public IActionResult AdicionarItem([FromBody] AdicionarItemCarrinho itemCarrinho)
    {
        return Ok();
    }

    [HttpGet]
    [EndpointSummary("Retorna o carrinho com a lista de produtos")]
    [ProducesResponseType<Carrinho>(StatusCodes.Status200OK, "application/json")]
    [ProducesResponseType<ErrorResponse>(StatusCodes.Status404NotFound, "application/json")]
    [EndpointGroupName("v1")]
    public IActionResult Visualizar()
    {
        return Ok();
    }

    [HttpPut]
    [EndpointSummary("Atualiza a quantidade de itens de um produto no carrinho")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType<ErrorResponse>(StatusCodes.Status400BadRequest, "application/json")]
    [EndpointGroupName("v1")]
    public IActionResult AtualizarQuantidade([FromQuery] string idSessao, [FromBody] AtualizarQuantidadeCarrinho atualizarQuantidade)
    {
        return Ok();
    }

    [HttpDelete("{idProduto}")]
    [EndpointSummary("Remove um produto do carrinho")]
    [ProducesResponseType<RemoverItemCarrinho>(StatusCodes.Status200OK, "application/json")]
    [ProducesResponseType<ErrorResponse>(StatusCodes.Status404NotFound, "application/json")]
    [EndpointGroupName("v1")]
    public IActionResult RemoverItem([FromRoute] int idProduto)
    {
        return Ok();
    }

    [HttpDelete]
    [EndpointSummary("Limpa o carrinho da sessão atual")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType<ErrorResponse>(StatusCodes.Status404NotFound, "application/json")]
    [EndpointGroupName("v1")]
    public IActionResult Limpar([FromQuery] string idSessao)
    {
        return Ok();
    }

    [HttpGet]
    [EndpointSummary("Retorna o estoque disponível de um produto")]
    [ProducesResponseType<ValidarQuantidadeInventario>(StatusCodes.Status200OK, "application/json")]
    [EndpointGroupName("v1")]
    public IActionResult Estoque([FromQuery] string idProduto)
    {
        return Ok();
    }
}
