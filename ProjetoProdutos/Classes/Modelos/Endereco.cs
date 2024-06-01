
namespace Classes.Modelos;

// classe Endereco 

public class Endereco
{
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Complemento { get; set; }
    public string Estado { get; set; }
    public string Rua { get; set; }
    public int Número { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Bairro: {Bairro}");
        Console.WriteLine($"Cidade: {Cidade}");
        Console.WriteLine($"Complemento: {Complemento}");
        Console.WriteLine($"Estado: {Estado}");
        Console.WriteLine($"Rua: {Rua}");
        Console.WriteLine($"Número: {Número}\n");
    }
}
