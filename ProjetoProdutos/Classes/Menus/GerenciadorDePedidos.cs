namespace ProjetoProdutos.Classes.Menus;

public class GerenciadorDePedidos: MenuBase
{

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

            switch (pegaOpacaoMenu())
            {
                case 1:
                    //
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
