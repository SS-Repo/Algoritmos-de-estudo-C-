using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //Faca um teste - imagine que vc tem uma loja virtual
            //e quer saber qual e o valor do maior e menor produto inserido
            //no carrinho de compras?
            //Faça este algoritmo e depois teste as possibilidades:
            //1 - entrada de dados em valores crescente
            //2 - entrada de dados em valores decrescente
            //3 - entrada de dados em um unico valor
            //Se apresentar algum erro no teste de unidade corrija 
            //Use Unit para testar seu codigo

            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.listaProdutos.Add(new Produto
            {
                nomeProduto = "Geladeira",
                preco = 450.0
            });
            carrinho.listaProdutos.Add(new Produto {
                nomeProduto = "Liquidficador",
                preco = 250.0
            });
            carrinho.listaProdutos.Add(new Produto
            {
                nomeProduto = "Jogo de Pratos",
                preco = 70.0
            });

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Console.WriteLine("O menor produto e: " + algoritmo.menor.nomeProduto);
            Console.WriteLine("O maior produto e: " + algoritmo.maior.nomeProduto);
            Console.ReadLine();
        }
    }
}
