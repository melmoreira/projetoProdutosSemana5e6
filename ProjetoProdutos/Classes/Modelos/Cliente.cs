namespace Classes.Modelos;

// Classe Cliente

public class Cliente
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Email { get; set; }
    public string Profissao { get; set; }
    public string Telefone { get; set; }
    public Endereco Endereco = new Endereco();

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"CPF: {CPF}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Profissao: {Profissao}");
        Console.WriteLine($"Telefone: {Telefone}");
        Endereco.ExibirInformacoes();
    }
}