using ProjetoProdutos.Classes.Interfaces;

namespace ProjetoProdutos.Classes.Modelos.Produtos;

// Primeira classe Produto
public class Livro : Produto, Identificavel
{
    string lsbn;
    int numeroDePaginas;


    public Livro(string Nome, string lsbn, int numeroDePaginas = 0) : base(Nome)
    {
        this.lsbn = lsbn;
        this.numeroDePaginas = numeroDePaginas;
    }

    string Identificavel.Identificar()
    {
        return Nome + lsbn;
    }
}

