namespace ApiFirst.Demo.Models;

public class AdicionarItemCarrinho
{
    public string? SessionId { get; set; }
    public int Quantidade { get; set; }
    public int IdProduto { get; set; }
}

public class AtualizarQuantidadeCarrinho
{
    public int IdProduto { get; set; }
    public int Quantidade { get; set; }
}