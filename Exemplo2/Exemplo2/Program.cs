using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //Faca um programa que conte ate 10 somente com os numeros pares....
            int num = 10;

            Console.WriteLine("Um programa que conta ate 10,somente os numeros pares");
            for (int i = 0; i <= num; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
