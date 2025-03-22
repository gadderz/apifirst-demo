using System;

namespace ApiFirst.Demo.Models;

public class Inventario
{
    public int Id { get; set; }
    public Produto? Produto { get; set; }
    public int Quantidade { get; set; }
}
