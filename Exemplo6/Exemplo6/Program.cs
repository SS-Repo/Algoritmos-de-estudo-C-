using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //Compare os numeros e diga se verdadeiro ou falso usando "ou" e "e"...
            //Algoritmo de comparacao 
            Console.WriteLine("Escreva um numero:");
            string num1 = Console.ReadLine();
            int numero1 = Convert.ToInt32(num1);

            Console.WriteLine("Escreva outro numero:");
            string num2 = Console.ReadLine();
            int numero2 = Convert.ToInt32(num2);
            //or
            if (numero1 == 0 || numero1 == 1)
            {
                Console.WriteLine("Verdadeiro");
            }
            else {
                Console.WriteLine("Falso");
            }
            //and
            if (numero1 == 0 && numero2 == 0) {
                Console.WriteLine("Verdadeiro");
            }
            else{
                Console.WriteLine("Falso");
            }
            Console.ReadLine();
        }
    }
}
