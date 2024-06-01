using System.Text.Json.Serialization;

namespace Classes.Modelos;

// Primeira classe Produto

// {
// "id":1,
// "title":"Fjallraven - Mochila dobrável nº 1, cabe em 15 laptops",
// "price":109,95,
// "description":"Sua mochila perfeita para uso diário e caminhadas na floresta. Stash seu laptop (até 15 polegadas) na capa acolchoada, seu dia a dia",
// "category":"roupas masculinas",
// "image":"https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg",
// "rating":{"rate":3.9,"count":120}
// }

public class Produto
{
    [JsonPropertyName("title")]
    public string Nome { get; set; }
    [JsonPropertyName("description")]
    public string Descricao { get; set; }
    [JsonPropertyName("price")]
    public double PrecoUnitario { get; set; }
    public int Quantidade { get; set; } = 0;

    //construtor
    public Produto (string Nome)
    {
        this.Nome=Nome;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Descrição: {Descricao}");
        Console.WriteLine($"Preço Unitário: {PrecoUnitario:C}");
        Console.WriteLine($"Quantidade: {Quantidade}\n");
    }
}

