using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //Represente uma matriz em 2 dimensoes [2x3] e imprima na tela...
            //Representacao de uma Matriz em 2 dimensoes
            int[,] num = new int[3,2] { {1,2} , {3,4} , {5,6} };

            Console.WriteLine("[" + num[0,0] + "]" + "[" + num[0,1] + "]");
            Console.WriteLine("[" + num[1,0] + "]" + "[" + num[1,1] + "]");
            Console.WriteLine("[" + num[2,0] + "]" + "[" + num[2,1] + "]");
            Console.ReadLine();
        }
    }
}
