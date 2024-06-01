namespace Classes;
using Classes.Modelos;

// Menu de Opções

public class GerenciadorDeProdutos

{

    List<Produto> produtos = new List<Produto>();

	public GerenciadorDeProdutos()
	{
	}

    void ExibirOpcoesDoMenu()
    {
        Console.Clear();
        Console.WriteLine("\nEscolha entre uma das seguintes opções abaixo:\n");
        Console.WriteLine("Digite 1 para Criar Produto");
        Console.WriteLine("Digite 2 para listar Produtos");
        Console.WriteLine("Digite 3 para sair");
    }

    void CriaProduto()
    {
        Console.Clear();
        Console.WriteLine("Por favor, Informe os dados do produto a seguir:\n");

        Console.Write("Nome: ");
        Produto produto = new Produto(Console.ReadLine());

        Console.Write("Descrição: ");
        produto.Descricao = Console.ReadLine();
        Console.Write("Preco unitário: ");
        produto.PrecoUnitario = float.Parse(Console.ReadLine());
        Console.Write("Quantidade: ");
        produto.Quantidade = int.Parse(Console.ReadLine());

        produtos.Add(produto);
    }

    void ListaProdutos()
    {
        Console.Clear();
        Console.WriteLine("Veja a seguir a lista de produtos:\n");
        foreach (var produto in produtos)
        {
            produto.ExibirInformacoes();  
        }
        EsperarInteracao();
    }

    public void ExecutaMenu()
    {
        bool executar = true;
        while(executar)
        {
            ExibirOpcoesDoMenu();

            Console.Write("Opção: ");
            int opcaoEscolhidaNumerica = int.Parse( Console.ReadLine() );
            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    CriaProduto();
                    break;
                case 2:
                    ListaProdutos();
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

    void EsperarInteracao()
    {
        Console.WriteLine("pressione enter para continuar...");
        Console.ReadLine();
    }

}


//------------------------------------------------------------------




