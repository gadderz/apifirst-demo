namespace ApiFirst.Demo.Models;

public class Produto {
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
}

public class AdicionarProduto {
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
}

public class ListarProdutos {
    public int IdVendedor { get; set; }
    public int IdCategoria { get; set; }
    public string? Busca { get; set; }
}