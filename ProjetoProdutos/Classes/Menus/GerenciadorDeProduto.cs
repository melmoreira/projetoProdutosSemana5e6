namespace ProjetoProdutos.Classes.Menus;
using System.Text.Json;
using System;
using System.Threading.Tasks;
using ProjetoProdutos.Classes.Modelos.Produtos;

// Menu de Opções

public class GerenciadorDeProdutos: MenuBase

{

    public List<Produto> produtos = new List<Produto>();

    public GerenciadorDeProdutos()
    {
    }

    void ExibirOpcoesDoMenu()
    {
        Console.Clear();
        Console.WriteLine("\nEscolha entre uma das seguintes opções abaixo:\n");
        Console.WriteLine("Digite 0 para pesquisa externa");
        Console.WriteLine("Digite 1 para Criar Produto");
        Console.WriteLine("Digite 2 para listar Produtos");
        Console.WriteLine("Digite 3 para menu anterior");
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

    public void Executa()
    {
        bool executar = true;
        while (executar)
        {
            ExibirOpcoesDoMenu();

            switch (pegaNumeroConsole())
            {
                case 0:
                    PesquisaProdutoAsync().Wait();
                    break;
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

    async Task PesquisaProdutoAsync()
    {
        try
        {
            Console.WriteLine("pesquisando produtos...");

            using (HttpClient client = new HttpClient())
            {
                string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");
                produtos = JsonSerializer.Deserialize<List<Produto>>(resposta);

                ListaProdutos();
            }
        }
        catch
        {
            Console.WriteLine("erro ao pesqusiar produtos...");
            EsperarInteracao();
        }

    }

    internal Produto verificaCodigoProduto(int codigoProduto)
    {
        if (codigoProduto > (produtos.Count - 1))
        {
            Console.WriteLine($"Produto {codigoProduto} não existe.");
            return null;

        }
        else
        {
            return produtos[codigoProduto];
        }
    }
}


//------------------------------------------------------------------




