// Classe Cliente

public class Cliente
{
    public string Nome;
    public string CPF;
    public string Email;
    public string Profissao;
    public string Telefone;
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