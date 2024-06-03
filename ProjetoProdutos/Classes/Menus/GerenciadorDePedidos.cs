
using ProjetoProdutos.Classes.Modelos.Pedido;
using ProjetoProdutos.Classes.Modelos.Produtos;

namespace ProjetoProdutos.Classes.Menus;

public class GerenciadorDePedidos: MenuBase
{
    public GerenciadorDeProdutos gerenciadorDeProdutos;
    List<Pedido> pedidos = new List<Pedido>();

    void ExibirOpcoesDoMenu()
    {
        Console.Clear();
        Console.WriteLine("\nEscolha entre uma das seguintes opções abaixo:\n");
        Console.WriteLine("Digite 1 para Criar Pedido");
        Console.WriteLine("Digite 3 para menu anterior");
    }

    public void Executa()
    {
        bool executar = true;
        while (executar)
        {
            ExibirOpcoesDoMenu();

            switch (pegaNumeroConsole())
            {
                case 1:
                    CriarPedido();
                    break;
                case 3:
                    executar = false;
                    break;
                default:
                    Console.WriteLine("Você escolheu uma opção invalida.");
                    EsperarInteracao();
                    break;
            }
        }

    }

    private void CriarPedido()
    {
        Pedido pedido = new Pedido(null, DateTime.Now);
        pedidos.Add(pedido);

        Console.WriteLine("Pedido criado com a data atual:");
        pedido.ExibirInformacoes();

        bool executa = true;
        while (executa)
        {
            Console.Write("Digite o numero do produto carregado anteriormente, ou precione enter para finalizar o pedido");
            int opcao = pegaNumeroConsole();
            if (opcao == -1) {
                executa = false;
            } else {
                Produto produto = gerenciadorDeProdutos.verificaCodigoProduto(opcao);
                if(produto != null)
                {
                    ItemDePedido item = new ItemDePedido();
                    item.produto = produto;
                    
                    Console.Write("Digite a quantidade desse produto: ");
                    item.quantidade = pegaNumeroConsole();


                    pedido.itemDePedidos.Add(item);

                    Console.WriteLine("Produto adicionado ao pedido.");
                    item.ExibirInformacoes();
                }
            }
            Console.WriteLine();
            EsperarInteracao();
        }
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Resumo do Pedido\n");
        Console.ForegroundColor = ConsoleColor.White;


        pedido.ExibirInformacoes();
        Console.WriteLine("\n\nPedido finalizado e adicionado a lista");
        EsperarInteracao();
    }
}
