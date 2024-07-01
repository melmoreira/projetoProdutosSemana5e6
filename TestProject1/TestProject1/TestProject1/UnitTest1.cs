using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoProdutos.Classes.Modelos.Pedido;
using ProjetoProdutos.Classes.Modelos.Produtos;
using System.IO;
using ProjetoProdutos.Classes.Modelos;

namespace ProjetoProdutos.Tests
{
    [TestClass]
    public class PedidoTests
    {
        [TestMethod]
        public void Pedido_Constructor_SetsProperties()
        {
            // Arrange
            var cliente = new Cliente { Nome = "João" };
            DateTime data = DateTime.Now;

            // Act
            Pedido pedido = new Pedido(cliente, data);

            // Assert
            Assert.AreEqual(cliente, pedido.cliente);
            Assert.AreEqual(data, pedido.data);
        }

        [TestMethod]
        public void Total_CalculatesCorrectTotal()
        {
            // Arrange
            var cliente = new Cliente { Nome = "Maria" };
            DateTime data = DateTime.Now;
            Pedido pedido = new Pedido(cliente, data);

            var produto1 = new Produto("Produto 1") { PrecoUnitario = 10.0 };
            var produto2 = new Produto("Produto 2") { PrecoUnitario = 20.0 };

            var item1 = new ItemDePedido { produto = produto1, quantidade = 1 };
            var item2 = new ItemDePedido { produto = produto2, quantidade = 1 };

            pedido.itemDePedidos.Add(item1);
            pedido.itemDePedidos.Add(item2);

            // Act
            double total = pedido.total;

            // Assert
            Assert.AreEqual(30.0, total);
        }

        [TestMethod]
        public void ExibirInformacoes_DisplaysCorrectInformation()
        {
            // Arrange
            var cliente = new Cliente { Nome = "Carlos" };
            DateTime data = DateTime.Now;
            Pedido pedido = new Pedido(cliente, data);

            var produto1 = new Produto("Produto 1") { PrecoUnitario = 10.0 };
            var produto2 = new Produto("Produto 2") { PrecoUnitario = 20.0 };

            var item1 = new ItemDePedido { produto = produto1, quantidade = 1 };
            var item2 = new ItemDePedido { produto = produto2, quantidade = 1 };

            pedido.itemDePedidos.Add(item1);
            pedido.itemDePedidos.Add(item2);

            // Redirect console output
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            pedido.ExibirInformacoes();

            // Assert
            var output = consoleOutput.ToString();
            Assert.IsTrue(output.Contains($"Resumo do Pedido {data}"));
            Assert.IsTrue(output.Contains("Nome: Produto 1"));
            Assert.IsTrue(output.Contains("Nome: Produto 2"));
            Assert.IsTrue(output.Contains("Quantidade: 1"));
            Assert.IsTrue(output.Contains("Subtotal Item:10"));
            Assert.IsTrue(output.Contains("Subtotal Item:20"));
            Assert.IsTrue(output.Contains("Total: 30"));
        }
    }
}