using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //Faca um programa que use recursividade para somar um numero qualquer...
            int numero = 0;
            Program pro = new Program();
            Console.WriteLine(pro.soma(numero));
            Console.ReadLine();
        }

        int soma(int num)
        {
            if (num == 10)
            {
                return num;
            }
            else
            {
                Console.WriteLine(num);
                return soma(num + 1);
            }
        }
    }
}
