namespace ProjetoProdutos.Classes.Modelos.Pedido;

// Classe Pedido
public class Pedido
{

    public Cliente cliente { get; set; }
    public DateTime data { get; set; }
    public List<ItemDePedido> itemDePedidos = new List<ItemDePedido>();

    public Pedido(Cliente cliente, DateTime data)
    {
        this.cliente = cliente;
        this.data = data;
    }

    public double total
    {
        get
        {
            double cumula = 0;
            foreach (var item in itemDePedidos)
                cumula += item.subTotal;
            return cumula;
        }
    }

    public void ExibirInformacoes()
    {
        cliente.ExibirInformacoes();
        foreach (var item in itemDePedidos)
        {
            item.ExibirInformacoes();
            Console.WriteLine("");
        }

        Console.WriteLine($"Total: {total}");
    }

}
