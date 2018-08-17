using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempo7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //Deixe o usuario escolher um numero de 1 a 3 e imprima na tela a escolha do usuario...
            //if aninhado
            Console.WriteLine("Escolha um numero de 1 a 3");
            string num = Console.ReadLine();
            if (num == "1")
            {
                Console.WriteLine("Escolheu 1");
            }
            else if (num == "2")
            {
                Console.WriteLine("Escolheu 2");
            }
            else {
                Console.WriteLine("Escolheu 3");
            }
            Console.ReadLine();
        }
    }
}
