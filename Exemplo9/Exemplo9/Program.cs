using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //Faca o usuario digitar um numero qualquer e se esse numero for verdadeiro a condicao "para",
            //porem se for falsa a condicao continua ate o usuario escolher o numero correto,mostre a quantidade
            //de tentativas do usuario na tela...
            //While
            //Contador
            int cont = 0;
           
            Console.WriteLine("digite um numero");
            string num = Console.ReadLine();
            
            while (num != "1")
            {
                cont++;
                Console.Write("Resposta Incorreta" + " = " + num + " Tentativas = " + cont + "\n");
                num = Console.ReadLine();
            }
            Console.Write("Resposta Correta" + " = " + num + " Tentativas = " + cont + "\n");
            Console.ReadLine();
        }
    }
}
