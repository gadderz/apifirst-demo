using System;

namespace ApiFirst.Demo.Models;

public class Inventario
{
    public int Id { get; set; }
    public Produto? Produto { get; set; }
    public int Quantidade { get; set; }
}

public class ValidarQuantidadeInventario
{
    public int IdProduto { get; set; }
    public int Quantidade { get; set; }
}