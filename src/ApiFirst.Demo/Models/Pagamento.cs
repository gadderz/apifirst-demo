using System;

namespace ApiFirst.Demo.Models;

public class Pagamento
{
    public int Id { get; set; }
    public FormaPagamento? FormaPagamento { get; set; }
    public decimal ValorTotal { get; set; }
}
