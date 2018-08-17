using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo22
{
    public class MaiorEMenor
    {
        public Produto menor { get; set; }
        public Produto maior { get; set; }

        public void Encontra(CarrinhoDeCompras carrinho) {
            foreach (Produto produto in carrinho.listaProdutos)
            {
                if (menor == null || produto.preco < menor.preco)
                {
                    menor = produto;
                }
                if (maior == null || produto.preco > maior.preco) {
                    maior = produto;
                }
            }
        }
    }
}
