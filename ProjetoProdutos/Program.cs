using ProjetoProdutos.Classes;
using ProjetoProdutos.Classes.Modelos;
using ProjetoProdutos.Classes.Modelos.Produtos;


GerenciadorDeProdutos gerenciadorDeProdutos = new GerenciadorDeProdutos();
gerenciadorDeProdutos.ExecutaMenu();

Console.WriteLine("*************************************************\n");

Console.WriteLine("Você é Bem Vindo ao Projeto Produto! Volte sempre!\n");


Produto produto1 = new Produto("manga")
{
    Descricao = "verde",
    PrecoUnitario = 2.50,
    Quantidade = 8,
};

Produto produto2 = new Produto("uva")
{ 
    Descricao = "rubi",
    PrecoUnitario = 10,
    Quantidade = 20,
};


produto1.ExibirInformacoes();
produto2.ExibirInformacoes();


Console.WriteLine("*************************************************\n");

Endereco endereco1 = new Endereco()
{
    Bairro = "Mooca",
    Cidade = "São Paulo",
    Complemento = "Casa",
    Estado = "SP",
    Rua = "Amador Bueno",
    Número = 687,
};


endereco1.ExibirInformacoes();


Console.WriteLine("*************************************************\n");

Cliente cliente1 = new Cliente();
cliente1.Nome = "Amalri Amadador";
cliente1.CPF = "173.485.968-44";
cliente1.Email = "amalriamador@gmail.com";
cliente1.Profissao = "Arquiteto";
cliente1.Telefone = "16999728304";
cliente1.Endereco.Bairro = "América";
cliente1.Endereco.Cidade = "Campinas";
cliente1.Endereco.Complemento = "2 andar, sala 3";
cliente1.Endereco.Estado = "SP";
cliente1.Endereco.Rua = "Azevedo Mendes";
cliente1.Endereco.Número = 2540;

cliente1.ExibirInformacoes();


