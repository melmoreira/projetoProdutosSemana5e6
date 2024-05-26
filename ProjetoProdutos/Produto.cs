// Primeira classe Produto
public class Produto
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public double PrecoUnitario { get; set; }
    public int Quantidade { get; set; }

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

