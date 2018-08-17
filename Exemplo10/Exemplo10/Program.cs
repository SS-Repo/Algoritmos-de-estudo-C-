using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //Escreva uma frase qualquer que pelo penos apareca na tela uma vez ou mais vezes e so saia quando o
            //usuario descobrir o numero correto.
            //Do While
            Console.WriteLine("Digite um numero");
            string num = Console.ReadLine();

            do
            {
              Console.WriteLine("testar -- do -- -- while -- e muito divertido!" + "\n");
              num = Console.ReadLine();
            } while (num != "1");
        }
    }
}
