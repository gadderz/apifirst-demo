namespace ApiFirst.Demo.Models;

public class ErrorResponse 
{
    public string? MessageError { get; set; }
    public string[] Errors { get; set; } = [];
}