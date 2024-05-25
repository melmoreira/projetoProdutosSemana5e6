// classe Endereco 

public class Endereco
{
    public string Bairro;
    public string Cidade;
    public string Complemento;
    public string Estado;
    public string Rua;
    public int Número;

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
