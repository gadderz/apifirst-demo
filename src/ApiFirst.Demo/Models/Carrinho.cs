namespace ApiFirst.Demo.Models;

public class Carrinho 
{
    public string? SessionId { get; set; }
    public ItemCarrinho[] Produtos = [];
}

public class ItemCarrinho
{
    public int Quantidade { get; set; }
    public int IdProduto { get; set; }
}

public class AdicionarItemCarrinho
{
    public string? SessionId { get; set; }
    public int Quantidade { get; set; }
    public int IdProduto { get; set; }
}

public class RemoverItemCarrinho
{
    public int IdProduto { get; set; }
}

public class AtualizarQuantidadeCarrinho : ItemCarrinho
{
}