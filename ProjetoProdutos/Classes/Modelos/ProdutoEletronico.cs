﻿namespace Classes.Modelos;

// Primeira classe Produto
public class ProdutoEletronico : Produto
{
    int potencia;
    int voltagem;
    int amperagem;

    //construtor
    public ProdutoEletronico(string Nome, int potencia, int voltagem) : base(Nome)
    {
        this.amperagem = potencia / voltagem;
        this.voltagem = voltagem;
        this.potencia = potencia;
    }

}

