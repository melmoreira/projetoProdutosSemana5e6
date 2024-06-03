namespace ProjetoProdutos.Classes.Menus;

public class MenuPrincipal: MenuBase
{
    private GerenciadorDeProdutos gerenciadorDeProdutos = new GerenciadorDeProdutos();
    private GerenciadorDePedidos gerenciadorDePedidos = new GerenciadorDePedidos();

    void ExibirOpcoesDoMenu()
    {
        Console.Clear();
        Console.WriteLine("\nEscolha entre uma das seguintes opções abaixo:\n");
        Console.WriteLine("Digite 1 para Menu de Produtos");
        Console.WriteLine("Digite 2 para Menu de Pedidos");
        Console.WriteLine("Digite 3 para sair");
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
                    gerenciadorDeProdutos.Executa();
                    break;
                case 2:
                    gerenciadorDePedidos.gerenciadorDeProdutos = gerenciadorDeProdutos;
                    gerenciadorDePedidos.Executa();
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
}
