// Primeira classe Produto
public class Produto
{
    public string Nome;
    public string Descricao;
    public double PrecoUnitario;
    public int Quantidade;

    //construtor
    public Produto (string Nome)
    {
        this.Nome=Nome;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Descrição: {Descricao}");
        Console.WriteLine($"Preço Unitário: {PrecoUnitario:C}");
        Console.WriteLine($"Quantidade: {Quantidade}\n");
    }
}

