namespace ApiFirst.Demo.Models;

public class Cliente
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Documento { get; set; }
    public string? Telefone { get; set; }
    public string? Senha { get; set; }
}

public class FazerLogin {
    public string? Email { get; set; }
    public string? Senha { get; set; }
}

public class RespostaLogin {
    public string? AccessToken { get; set; }
}

public class CadastrarCliente
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Documento { get; set; }
    public string? Telefone { get; set; }
    public string? Senha { get; set; }
}