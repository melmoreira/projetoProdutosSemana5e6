using ProjetoProdutos.Classes.Modelos.Produtos;

namespace ProjetoProdutos.Classes.Modelos.Pedido;

public class ItemDePedido
{
    public Produto produto;
    public int quantidade { get; set; }

    public double subTotal
    {
        get { return quantidade * produto.PrecoUnitario; }
    }

    public void ExibirInformacoes()
    {
        produto.ExibirInformacoes();
        Console.WriteLine($"Quantidade: {quantidade}");
        Console.WriteLine($"Subtotal:{subTotal}");
    }
}



