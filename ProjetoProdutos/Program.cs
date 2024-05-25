Console.WriteLine("Bem Vindo ao Projeto Produto!\n");



Produto produto1 = new Produto("manga");
produto1.Descricao = "verde";
produto1.PrecoUnitario = 2.50;
produto1.Quantidade = 8;

Produto produto2 = new Produto("uva");
produto2.Descricao = "rubi";
produto2.PrecoUnitario = 10;
produto2.Quantidade = 20;


produto1.ExibirInformacoes();
produto2.ExibirInformacoes();


Console.WriteLine("*************************************************\n");

Endereco endereco1 = new Endereco();
endereco1.Bairro = "Mooca";
endereco1.Cidade = "São Paulo";
endereco1.Complemento = "Casa";
endereco1.Estado = "SP";
endereco1.Rua = "Amador Bueno";
endereco1.Número = 687;


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


Console.WriteLine("*************************************************\n");


GerenciadorDeProdutos gerenciadorDeProdutos = new GerenciadorDeProdutos();
gerenciadorDeProdutos.ExecutaMenu();
