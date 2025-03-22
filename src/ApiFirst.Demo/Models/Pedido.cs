using System;

namespace ApiFirst.Demo.Models;

public class Pedido
{
    public int Id { get; set; }
    public List<Produto>? Produtos { get; set; }
    public Cliente? Cliente { get; set; }
    public Pagamento? Pagamento { get; set; }
    public Endereco? EnderecoEntrega { get; set; }
}
