using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exemplo22.UnitTest
{
    [TestClass]
    public class TestaMaiorEMenor
    {
        [TestMethod]
        public void OrdemDecrescente()
        {
            //Arrange
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.listaProdutos.Add(new Produto
            {
                nomeProduto = "Geladeira",
                preco = 450.0
            });
            carrinho.listaProdutos.Add(new Produto
            {
                nomeProduto = "Liquidficador",
                preco = 250.0
            });
            carrinho.listaProdutos.Add(new Produto
            {
                nomeProduto = "Jogo de Pratos",
                preco = 70.0
            });

            //Act
            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);
            //Asserts
            Assert.AreEqual("Jogo de Pratos",algoritmo.menor.nomeProduto);
            Assert.AreEqual("Geladeira",algoritmo.maior.nomeProduto);
        }
        [TestMethod]
        public void SomenteUmProduto() {
            //Arrange
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.listaProdutos.Add(new Produto
            {
                nomeProduto = "Geladeira",
                preco = 450.0
            });

            //Act
            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            //Asserts
            Assert.AreEqual("Geladeira", algoritmo.menor.nomeProduto);
            Assert.AreEqual("Geladeira", algoritmo.maior.nomeProduto);
        }
    }
}
