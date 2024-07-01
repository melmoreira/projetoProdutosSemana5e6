namespace ProjetoProdutos.Classes.Modelos.Pedido;

// Classe Pedido
/// <summary>
/// Representa um pedido de cliente contendo múltiplos itens.
/// </summary>
public class Pedido
{
    /// <summary>
    /// Obtém ou define o cliente que fez o pedido.
    /// </summary>
    public Cliente cliente { get; set; }

    /// <summary>
    /// Obtém ou define a data em que o pedido foi realizado.
    /// </summary>
    public DateTime data { get; set; }

    /// <summary>
    /// Obtém a lista de itens no pedido.
    /// </summary>
    public List<ItemDePedido> itemDePedidos = new List<ItemDePedido>();

    /// <summary>
    /// Inicializa uma nova instância da classe <see cref="Pedido"/> com o cliente e a data especificados.
    /// </summary>
    /// <param name="cliente">O cliente que fez o pedido.</param>
    /// <param name="data">A data em que o pedido foi realizado.</param>
    public Pedido(Cliente cliente, DateTime data)
    {
        this.cliente = cliente;
        this.data = data;
    }

    /// <summary>
    /// Obtém o valor total do pedido somando os subtotais de todos os itens.
    /// </summary>
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

    /// <summary>
    /// Exibe as informações do pedido, incluindo as informações de cada item e o valor total.
    /// </summary>
    public void ExibirInformacoes()
    {
        // cliente.ExibirInformacoes();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Resumo do Pedido {data}\n");
        Console.ForegroundColor = ConsoleColor.White;

        foreach (var item in itemDePedidos)
        {
            item.ExibirInformacoes();
            Console.WriteLine("");
        }
        Console.WriteLine("");
        Console.WriteLine($"Total: {total}");
        Console.WriteLine("");
    }
}